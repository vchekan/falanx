// TODO fine tune visibility
module Falanx.Json.Parser

open System

let log msg =
    printfn "%s" msg

[<RequireQualifiedAccess>]
type JValue =
    | String of string
    | Int of int64
    | Double of double
    | Bool of bool
    | Object of string*int
    | Array
    | Null

type ParseState = {
    json: string
    mutable pos: int
}

type ParseResult<'a> =
    | Ok of 'a
    | Error of string

type Mapper<'a, 'b> = ParseState -> 'a -> ParseResult<'b>
type Generator<'a> = ParseState -> ParseResult<'a>

// Parser expression
type ParserBuilder() =
    member __.Return(x) = Ok(x)
    member __.ReturnFrom(x) = x
    member self.Zero() = self.Return ()
    member __.Delay(f) = f
    member __.Run(f) = f()
    member __.Bind(x, f) =
        match x with
            | Ok(a) -> f(a)
            | Error(e) -> Error(e)
    member self.While(guard, body) = 
        if guard() then 
            self.Bind(body(), fun() -> self.While(guard, body)) 
        else 
            self.Zero()
    member self.Combine (a, b) =
        self.Bind(a, b)
let parser = ParserBuilder()

let matchChar (ch: char) (state: ParseState) : ParseResult<unit> = 
    if state.pos < state.json.Length then 
        let ch' = state.json.Chars state.pos
        if ch' = ch then
            state.pos <- state.pos + 1
            Ok(())
        else
            Error <| sprintf "Expected '%c' but got '%c' at position %d" ch ch' (state.pos + 1)
    else
        Error(sprintf "End of string while matching %c" ch)

let matchString (state: ParseState): ParseResult<string> =
    log "Matching string"
    parser {
        do! matchChar '"' state
        let mutable pos' = state.pos
        let! str = 
            while pos' < state.json.Length && state.json.Chars pos' <> '"' do
                pos' <- pos' + 1
            if pos' < state.json.Length && state.json.Chars pos' = '"' then
                let res = state.json.Substring(state.pos, pos' - state.pos)
                state.pos <- pos' + 1
                Ok(res)
            else
                Error <| sprintf "Unterminated string (started at %d)" state.pos 
        return str
    }

(*
let matchValue (state: ParseState) : ParseResult<JValue> =
    if state.pos >= state.json.Length then 
        Error("End of string while parsing value")
    else
        parser {
            let ch = state.json.Chars state.pos
            if ch = '"' then
                let! str = matchString state
                return JValue.String str
            //else if ch >= '0' && ch <= '9' then
            //    // TODO: how to differentiate between int and float? Do we need to? 
            //    // What is standard behaviour whenn mapping int <-> float when there is float part?
            //    return JValue.Int (matchInt state)
            //else if ch = '{' then
            //    JValue.Object matchObject
            //else if ch = '[' then
            //    JValue.Array matchArray
            //else if ch = 't' then
            //    JValue.Bool parseTrue
            //else if ch = 'f' then 
            //    JValue.Bool parseFalse
            //else if ch = 'n' then
            //    parseNull 
            //    |> bind JValue.Null
            else
                return! Error(sprintf "Unrecoglized value at position %d" state.pos)
        }
*)

let ws state =
    let rec r() =
        if state.pos >= state.json.Length then ()
        else
            let ch = state.json.Chars state.pos
            if ch = ' ' || ch = '\t' || ch = '\r' || ch = '\n' then
                state.pos <- state.pos + 1
                r()
            else ()
    r()
    state
            
let matchInt64 (state: ParseState) : ParseResult<int64> =
    log "Matching int64"
    ws state |> ignore
    let mutable pos' = state.pos
    let rec r() =
        if state.pos >= state.json.Length then 
            pos'
        else if Char.IsDigit <| state.json.Chars state.pos then
            state.pos <- state.pos + 1
            r()
        else
            pos'
    let p = r()
    if state.pos = pos' then
        Error("Int not found")
    else 
        let i = state.json.Substring(pos', state.pos - pos')
        match Int64.TryParse i with
            | (true, i) -> 
                log <| sprintf "Matched int64 %d" i
                Ok(i)
            // TODO: truncate i if it is too long or contains newlines
            | (false, _) -> Error(sprintf "Expected int but got: '%s'" i)
        
let peek state =
    if state.pos >= state.json.Length then
        Error <| sprintf "peek: End of stream at %d" state.pos
    else
        let ch = state.json.Chars state.pos
        log <| sprintf "peek at %d: '%c'" state.pos ch
        Ok <| ch

let matchKeyAndColumn (state: ParseState) : ParseResult<Option<string>> =
    log "Matching field"
    parser {
        let! ch = ws >> peek <| state
        if ch = '}' then
            return None
        else        
            let! key = 
                ws >> matchString <| state
            log <| sprintf "Found key %s" key

            do! matchChar ':' state
            return Some key
    }
let matchKeyAndColumn2 (state: ParseState) : seq<string> =
    failwith "notimplemented yet"

//
// Convinience functions
//
let startObject = 
    log "Start object"
    ws >> matchChar '{'
let endObject = 
    log "End object"
    ws >> matchChar '}'