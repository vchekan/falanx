module Falanx.JsonTests

open Expecto
open protobuf_unittest3
open Fleece
open Newtonsoft
open Jet.Generated

let jFormatterTests = 
    testList "Json parser" [
        test "Original field name accepted" {
            let json = "{ \"single_int32\": 10 }"
            match parseJson json with
                | Ok(msg) -> 
                    Expect.equal (Some(10)) msg.singleInt32 "Failed to deserialize singleInt32"
                    Expect.equal (Some(0L)) msg.singleInt64 "Expected default 0 on singleInt64"
                    Expect.equal (Some("")) msg.singleString "Expected default empty string"
                | Error(err) -> 
                    failwithf "Failed to parse json: %s" err
        }
    ]

//let simpleMessageTest = 
//    testList "Simple Message" [
//        test "All props" {
//            let json = "{ \"single_int32\": 10 }"
//            //let msg = 
//            match msg.testOneof with
//                | Some(SampleMessage.First_name(fname)) ->
//                    Expect.equal "first name" fname "Invalid first name"
//                | _ -> failwith "Unexpected variant"
//        }
//    ]
    
