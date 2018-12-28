module protobuf_mock

open System
open Falanx.Json.Parser

type TestAllTypesMock =
    { mutable singleInt32 : int option
      mutable singleInt64 : int64 option
      mutable singleUint32 : UInt32 option
      mutable singleUint64 : UInt64 option
      mutable singleSint32 : int option
      mutable singleSint64 : int64 option
      mutable singleFixed32 : UInt32 option
      mutable singleFixed64 : UInt64 option
      mutable singleSfixed32 : int option
      mutable singleSfixed64 : int64 option
      mutable singleFloat : float32 option
      mutable singleDouble : float option
      mutable singleBool : bool option
      mutable singleString : string option
      mutable repeatedInt32 : int ResizeArray
      mutable repeatedInt64 : int64 ResizeArray
      mutable repeatedUint32 : UInt32 ResizeArray
      mutable repeatedUint64 : UInt64 ResizeArray
      mutable repeatedSint32 : int ResizeArray
      mutable repeatedSint64 : int64 ResizeArray
      mutable repeatedFixed32 : UInt32 ResizeArray
      mutable repeatedFixed64 : UInt64 ResizeArray
      mutable repeatedSfixed32 : int ResizeArray
      mutable repeatedSfixed64 : int64 ResizeArray
      mutable repeatedFloat : float32 ResizeArray
      mutable repeatedDouble : float ResizeArray
      mutable repeatedBool : bool ResizeArray
      mutable repeatedString : string ResizeArray }

    static member private falanxKeyValueMap key = 
        [ 
            "single_int32", (Falanx.Json.Parser.matchInt)
            "single_int64", (Falanx.Json.Parser.matchInt)
        ] 
        |> Map.ofList
        |> Map.tryFind key

    static member ofJson2(json: string) =

        let mutable singleInt32 = None
        let mutable singleInt64 = None
        let mutable singleUint32 = None
        let mutable singleUint64 = None
        let mutable singleSint32 = None
        let mutable singleSint64 = None
        let mutable singleFixed32 = None
        let mutable singleFixed64 = None
        let mutable singleSfixed32 = None
        let mutable singleSfixed64 = None
        let mutable singleFloat = None
        let mutable singleDouble = None
        let mutable singleBool = None
        let mutable singleString = None
        let mutable repeatedInt32 = None
        let mutable repeatedInt64 = None
        let mutable repeatedUint32 = None
        let mutable repeatedUint64 = None
        let mutable repeatedSint32 = None
        let mutable repeatedSint64 = None
        let mutable repeatedFixed32 = None
        let mutable repeatedFixed64 = None
        let mutable repeatedSfixed32 = None
        let mutable repeatedSfixed64 = None
        let mutable repeatedFloat = None
        let mutable repeatedDouble = None
        let mutable repeatedBool = None
        let mutable repeatedString = None

        let x = 
            parser {
                let state = {ParseState.json = json; pos = 0}
                do! startObject state
                // matchField should 
                //      return Option, until next field is matching.
                //      return key
                // "match" by key 
                //
                //
                let! f = matchField TestAllTypesMock.falanxKeyValueMap state
                do! endObject state
                return f
            }


        printfn "x: %A" x

        Ok("")


