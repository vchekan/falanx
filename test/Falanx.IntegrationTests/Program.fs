module Falanx.Program

open Expecto
open System
open System.IO
open Jet.Generated
open protobuf_mock
open Falanx.Json.Parser

[<EntryPoint>]
let main argv =
    //JsonTests.jFormatterTests
    //JsonTests.simpleMessageTest
    //|> runTests defaultConfig

    let json = """{ "single_int32": 10 }"""
    match TestAllTypesMock.ofJson2(json) with
        | Ok(res) ->
            printfn "Result: %O" res
        | Error(err) ->
            printfn "Error: %s" err
    0
