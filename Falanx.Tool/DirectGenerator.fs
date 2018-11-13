module Falanx.Generator.DirectGenerator

open System.Text
open Froto.Parser.Ast
open System

let notImplemented = "Not implemented yet"
let tab = "  "
let header ns : string = 
    let created = DateTime.Now.ToString("yyyy.MM.dd hh:mm:ss")
    sprintf "
(********************************************************************
                Autogenereted file. Do not edit.
                Created: %s
********************************************************************)
namespace %s

open System
open System.Collections.Generic
open Fleece.Newtonsoft

"       <| created <| ns

type private Builder(ns) = 
    let str = 
        new StringBuilder(header ns)
    let mutable ident = 0
    member __.code() = str.ToString()
    member __.println (lines: string list) =
        lines
        |> List.iter(fun line -> str.Append(String.replicate ident tab).Append(line).Append('\n') |> ignore)
    member __.println(line: string) = str.Append(String.replicate ident tab).Append(line).Append('\n') |> ignore
    member __.print(line: string) = str.Append(String.replicate ident tab).Append(line) |> ignore
    member __.withIdent fn =
        ident <- ident + 1
        fn()
        ident <- ident - 1
        

let toFsType type_ =
    match type_ with
        | TDouble   -> "double"
        | TFloat    -> "float32"
        | TInt32    -> "int"
        | TInt64    -> "int64"
        | TUInt32   -> "uint32"
        | TUInt64   -> "uint64"
        | TBool     -> "bool"
        | TString   -> "string"
        | TBytes    -> "Array<byte>"
        | TIdent(id) -> id
        | TSInt32 
        | TSInt64
        | TFixed32 
        | TFixed64 
        | TSFixed32 
        | TSFixed64 -> failwithf "Type %O is not implemented" type_

let directGenerator file ns : string = 
    let builder = new Builder(ns)

    let fieldStatement id label type_ fNum opts = 
        let maybeArray = if label = TRepeated then " ResizeArray" else ""
        sprintf "mutable %s : %s%s" id (toFsType type_) maybeArray |> builder.println

    let messageStatement (statement: PMessageStatement) : unit =
        match statement with
            | TField(id, label, type_, fNum, opts) -> fieldStatement id label type_ fNum opts
            | TMap(_)
            | TGroup(_)
            | TReservedRanges(_)
            | TReservedNames(_)
            | TOneOf(_)
            | TExtensions(_)
            | TMessageExtend(_)
            | TMessageMessage(_)
            | TMessageOption(_)
            | TMessageEnum(_) ->
                failwith notImplemented

    /// Implement json codec, Fleece style:
    /// <c>
    /// static member JsonObjCodec =
    ///     fun f l a c -> { name = (f, l); age = a; children = c }
    ///     |> withFields
    ///     |> jfield    "firstName" (fun x -> fst x.name)
    ///     |> jfield    "lastName"  (fun x -> snd x.name)
    ///     |> jfieldOpt "age"       (fun x -> x.age)
    ///     |> jfield    "children"  (fun x -> x.children)
    /// </c>
    let json (statements: PMessageStatement list) : unit =
        builder.println "static member JsonObjectCodec ="
        builder.withIdent(fun () -> 
            let paramsJs = 
                statements |> List.map(
                    fun p -> 
                        match p with
                            | TField(id, _label, _type_, _fNum, _opts) -> id
                            | _ -> failwith notImplemented
                    )
                |> String.concat " "
            sprintf "fun %s -> " paramsJs |> builder.println
            builder.withIdent(fun () -> 
                builder.println "{"
                builder.withIdent(fun () ->
                    statements
                    |> List.iter(fun statement -> 
                        match statement with
                            | TField(id, _,_,_,_) -> sprintf "%s = %s" id id
                            | _ -> failwith notImplemented
                        |> builder.println
                    )
                )
                builder.println "}"
                builder.println "|> withFields"
                for statement in statements do
                    let id = match statement with
                        | TField(id,_,_,_,_) -> id
                        | _ -> failwith notImplemented
                    builder.println (sprintf "|> jfield\t\"%s\"\t(fun x -> x.%s)" id id)
            )
        )

    let message (id: TIdent, statements) : unit =
        builder.println [
            "[<CLIMutable>]"
            sprintf "type %s =" id
        ]
        builder.withIdent(fun () -> 
            builder.println "{"
            builder.withIdent(fun () ->
                statements
                |> List.iter messageStatement
            )
            builder.println "}"
            json statements
        )

    let statement (m: PStatement) : unit = 
        printfn "message: %O" m
        match m with 
            // Syntax is expected to be handled and skipped at beginning of parsing
            | PStatement.TSyntax(_) -> failwith "Error. Did not exapect syntax statement"
            | PStatement.TImport(_) 
            | PStatement.TPackage(_)
            | PStatement.TOption(_) 
            | PStatement.TEnum(_)
            | PStatement.TExtend(_)
            | PStatement.TService(_) -> failwith notImplemented
            | PStatement.TMessage(id, statements) -> message (id, statements)
        builder.println ""


    //
    // Start parsing
    //
    let res = Froto.Parser.Parse.fromFile file
    if res.Length = 0 then ""
    else
        // We support only proto3 syntax
        match res.Head with
            | PStatement.TSyntax(TProto3) -> ()
            | PStatement.TSyntax(TProto2) -> failwith "We support only syntax=proto3"
            | _ -> failwith "Syntax declaration is expected to be first statement i the proto file"

        res.Tail
        |> List.iter(statement)
        
        builder.code()


