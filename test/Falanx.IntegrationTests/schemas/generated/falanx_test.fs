namespace rec protobuf_unittest3

open System
open System.Collections.Generic
open Froto.Serialization
open Falanx.Proto.Codec.Binary
open Falanx.Proto.Codec.Binary.Primitives
open Newtonsoft.Json.Linq
open Fleece.Newtonsoft

[<CLIMutable>]
type TestAllTypes =
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

    static member JsonObjCodec =
        fun singleInt32 singleInt64 singleUint32 singleUint64 singleSint32 singleSint64 singleFixed32 singleFixed64 singleSfixed32 singleSfixed64 singleFloat singleDouble singleBool singleString repeatedInt32 repeatedInt64 repeatedUint32 repeatedUint64 repeatedSint32 repeatedSint64 repeatedFixed32 repeatedFixed64 repeatedSfixed32 repeatedSfixed64 repeatedFloat repeatedDouble repeatedBool repeatedString -> 
            { singleInt32 = singleInt32
              singleInt64 = singleInt64
              singleUint32 = singleUint32
              singleUint64 = singleUint64
              singleSint32 = singleSint32
              singleSint64 = singleSint64
              singleFixed32 = singleFixed32
              singleFixed64 = singleFixed64
              singleSfixed32 = singleSfixed32
              singleSfixed64 = singleSfixed64
              singleFloat = singleFloat
              singleDouble = singleDouble
              singleBool = singleBool
              singleString = singleString
              repeatedInt32 = repeatedInt32
              repeatedInt64 = repeatedInt64
              repeatedUint32 = repeatedUint32
              repeatedUint64 = repeatedUint64
              repeatedSint32 = repeatedSint32
              repeatedSint64 = repeatedSint64
              repeatedFixed32 = repeatedFixed32
              repeatedFixed64 = repeatedFixed64
              repeatedSfixed32 = repeatedSfixed32
              repeatedSfixed64 = repeatedSfixed64
              repeatedFloat = repeatedFloat
              repeatedDouble = repeatedDouble
              repeatedBool = repeatedBool
              repeatedString = repeatedString } : TestAllTypes
        |> fun f -> 
            Fleece.Newtonsoft.withFields<Option<Int32> -> Option<Int64> -> Option<UInt32> -> Option<UInt64> -> Option<Int32> -> Option<Int64> -> Option<UInt32> -> Option<UInt64> -> Option<Int32> -> Option<Int64> -> Option<Single> -> Option<Double> -> Option<Boolean> -> Option<String> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes, IReadOnlyDictionary<String, JToken>, String, TestAllTypes, String, JToken> 
                (f)
        |> fun codec -> 
            let decode =
                let _bind_77365ba3df154b2791d7e93fde3a7184, _ = codec
                _bind_77365ba3df154b2791d7e93fde3a7184
            
            let encode =
                let _, _bind_1066398a16774dc99b7e3dfb751a1e40 = codec
                _bind_1066398a16774dc99b7e3dfb751a1e40
            
            Fleece.Newtonsoft.jfieldOpt<TestAllTypes, Int32, Option<Int64> -> Option<UInt32> -> Option<UInt64> -> Option<Int32> -> Option<Int64> -> Option<UInt32> -> Option<UInt64> -> Option<Int32> -> Option<Int64> -> Option<Single> -> Option<Double> -> Option<Boolean> -> Option<String> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("singleInt32") (fun x -> x.singleInt32) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_f0c387e696a1419fa9b97746e5748978, _ = codec
                _bind_f0c387e696a1419fa9b97746e5748978
            
            let encode =
                let _, _bind_65c08580a41444fc946edb04cd482116 = codec
                _bind_65c08580a41444fc946edb04cd482116
            
            Fleece.Newtonsoft.jfieldOpt<TestAllTypes, Int64, Option<UInt32> -> Option<UInt64> -> Option<Int32> -> Option<Int64> -> Option<UInt32> -> Option<UInt64> -> Option<Int32> -> Option<Int64> -> Option<Single> -> Option<Double> -> Option<Boolean> -> Option<String> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("singleInt64") (fun x -> x.singleInt64) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_8c4d0bb913a149689815c5369fc2f088, _ = codec
                _bind_8c4d0bb913a149689815c5369fc2f088
            
            let encode =
                let _, _bind_9adfac889a7342b387e362eb3cea1847 = codec
                _bind_9adfac889a7342b387e362eb3cea1847
            
            Fleece.Newtonsoft.jfieldOpt<TestAllTypes, UInt32, Option<UInt64> -> Option<Int32> -> Option<Int64> -> Option<UInt32> -> Option<UInt64> -> Option<Int32> -> Option<Int64> -> Option<Single> -> Option<Double> -> Option<Boolean> -> Option<String> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("singleUint32") (fun x -> x.singleUint32) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_dc63d19dd35d452e9001b9e779c765a4, _ = codec
                _bind_dc63d19dd35d452e9001b9e779c765a4
            
            let encode =
                let _, _bind_4ed2cf410f8c499ca19f86ab84d5faac = codec
                _bind_4ed2cf410f8c499ca19f86ab84d5faac
            
            Fleece.Newtonsoft.jfieldOpt<TestAllTypes, UInt64, Option<Int32> -> Option<Int64> -> Option<UInt32> -> Option<UInt64> -> Option<Int32> -> Option<Int64> -> Option<Single> -> Option<Double> -> Option<Boolean> -> Option<String> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("singleUint64") (fun x -> x.singleUint64) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_2a443975ec4c4ac3a751f95577dcd79d, _ = codec
                _bind_2a443975ec4c4ac3a751f95577dcd79d
            
            let encode =
                let _, _bind_09a59944b3ad4cb3bca5639254d469a9 = codec
                _bind_09a59944b3ad4cb3bca5639254d469a9
            
            Fleece.Newtonsoft.jfieldOpt<TestAllTypes, Int32, Option<Int64> -> Option<UInt32> -> Option<UInt64> -> Option<Int32> -> Option<Int64> -> Option<Single> -> Option<Double> -> Option<Boolean> -> Option<String> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("singleSint32") (fun x -> x.singleSint32) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_197937325b884eedba6023da28d5b2cd, _ = codec
                _bind_197937325b884eedba6023da28d5b2cd
            
            let encode =
                let _, _bind_7a0d15b3fe5e44c2b12b8747ffebdd8e = codec
                _bind_7a0d15b3fe5e44c2b12b8747ffebdd8e
            
            Fleece.Newtonsoft.jfieldOpt<TestAllTypes, Int64, Option<UInt32> -> Option<UInt64> -> Option<Int32> -> Option<Int64> -> Option<Single> -> Option<Double> -> Option<Boolean> -> Option<String> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("singleSint64") (fun x -> x.singleSint64) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_0d950d12d6044f41ad8723a65443661d, _ = codec
                _bind_0d950d12d6044f41ad8723a65443661d
            
            let encode =
                let _, _bind_0f9c3c46a742482daad91a4ebf1dd219 = codec
                _bind_0f9c3c46a742482daad91a4ebf1dd219
            
            Fleece.Newtonsoft.jfieldOpt<TestAllTypes, UInt32, Option<UInt64> -> Option<Int32> -> Option<Int64> -> Option<Single> -> Option<Double> -> Option<Boolean> -> Option<String> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("singleFixed32") (fun x -> x.singleFixed32) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_d96e410fc88e4c93ae90563f0542a064, _ = codec
                _bind_d96e410fc88e4c93ae90563f0542a064
            
            let encode =
                let _, _bind_a8e6f6e12a3b4afc8a99d7fffdccf6ed = codec
                _bind_a8e6f6e12a3b4afc8a99d7fffdccf6ed
            
            Fleece.Newtonsoft.jfieldOpt<TestAllTypes, UInt64, Option<Int32> -> Option<Int64> -> Option<Single> -> Option<Double> -> Option<Boolean> -> Option<String> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("singleFixed64") (fun x -> x.singleFixed64) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_295f71c8f0144100b895a1045039cd02, _ = codec
                _bind_295f71c8f0144100b895a1045039cd02
            
            let encode =
                let _, _bind_7b73154649f34b398c6d4ab3fd5b29c2 = codec
                _bind_7b73154649f34b398c6d4ab3fd5b29c2
            
            Fleece.Newtonsoft.jfieldOpt<TestAllTypes, Int32, Option<Int64> -> Option<Single> -> Option<Double> -> Option<Boolean> -> Option<String> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("singleSfixed32") (fun x -> x.singleSfixed32) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_4bd95db8d4cd4511b290e07836ad905e, _ = codec
                _bind_4bd95db8d4cd4511b290e07836ad905e
            
            let encode =
                let _, _bind_3809c9d895cb4c7287c4684a4dcbb3bb = codec
                _bind_3809c9d895cb4c7287c4684a4dcbb3bb
            
            Fleece.Newtonsoft.jfieldOpt<TestAllTypes, Int64, Option<Single> -> Option<Double> -> Option<Boolean> -> Option<String> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("singleSfixed64") (fun x -> x.singleSfixed64) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_3819ee8240b948038a6e1a88f8d7b503, _ = codec
                _bind_3819ee8240b948038a6e1a88f8d7b503
            
            let encode =
                let _, _bind_fb8657559c9b40aeb5a54dfdbbafb2fc = codec
                _bind_fb8657559c9b40aeb5a54dfdbbafb2fc
            
            Fleece.Newtonsoft.jfieldOpt<TestAllTypes, Single, Option<Double> -> Option<Boolean> -> Option<String> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("singleFloat") (fun x -> x.singleFloat) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_26834ec31f37407fa38b4dbc048dda64, _ = codec
                _bind_26834ec31f37407fa38b4dbc048dda64
            
            let encode =
                let _, _bind_686cea12f9b14714a6a2442520ffff9f = codec
                _bind_686cea12f9b14714a6a2442520ffff9f
            
            Fleece.Newtonsoft.jfieldOpt<TestAllTypes, Double, Option<Boolean> -> Option<String> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("singleDouble") (fun x -> x.singleDouble) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_9bd1ad423e774962aef6fdbea9854ea2, _ = codec
                _bind_9bd1ad423e774962aef6fdbea9854ea2
            
            let encode =
                let _, _bind_7b3bfd32b9cc4db4930b685f000b91c3 = codec
                _bind_7b3bfd32b9cc4db4930b685f000b91c3
            
            Fleece.Newtonsoft.jfieldOpt<TestAllTypes, Boolean, Option<String> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("singleBool") (fun x -> x.singleBool) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_4798100f0c6b497c9f3172afdc272d75, _ = codec
                _bind_4798100f0c6b497c9f3172afdc272d75
            
            let encode =
                let _, _bind_118ce56218c34f2abeb0d9aa30918a60 = codec
                _bind_118ce56218c34f2abeb0d9aa30918a60
            
            Fleece.Newtonsoft.jfieldOpt<TestAllTypes, String, List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("singleString") (fun x -> x.singleString) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_1c846bc39dab41a4ba9ebfd0dffedf74, _ = codec
                _bind_1c846bc39dab41a4ba9ebfd0dffedf74
            
            let encode =
                let _, _bind_d5aff86537f040a780f40cd359cdbce6 = codec
                _bind_d5aff86537f040a780f40cd359cdbce6
            
            Fleece.Newtonsoft.jfield<TestAllTypes, List<Int32>, List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("repeatedInt32") (fun x -> x.repeatedInt32) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_e4753c8f40cf486fbd471b0784998885, _ = codec
                _bind_e4753c8f40cf486fbd471b0784998885
            
            let encode =
                let _, _bind_3ebd882fade1493180d4ff61bf6ca61a = codec
                _bind_3ebd882fade1493180d4ff61bf6ca61a
            
            Fleece.Newtonsoft.jfield<TestAllTypes, List<Int64>, List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("repeatedInt64") (fun x -> x.repeatedInt64) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_ec31a9dae24f4d9bb352ca38467e14f1, _ = codec
                _bind_ec31a9dae24f4d9bb352ca38467e14f1
            
            let encode =
                let _, _bind_8b6e2ef5b4db478f853dec177e25547a = codec
                _bind_8b6e2ef5b4db478f853dec177e25547a
            
            Fleece.Newtonsoft.jfield<TestAllTypes, List<UInt32>, List<UInt64> -> List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("repeatedUint32") (fun x -> x.repeatedUint32) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_ff57615f5e094d7c966eabdfb2a5eb7c, _ = codec
                _bind_ff57615f5e094d7c966eabdfb2a5eb7c
            
            let encode =
                let _, _bind_4b0337eadb7547068af1332af686c531 = codec
                _bind_4b0337eadb7547068af1332af686c531
            
            Fleece.Newtonsoft.jfield<TestAllTypes, List<UInt64>, List<Int32> -> List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("repeatedUint64") (fun x -> x.repeatedUint64) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_f93a7605cd5e49e8b2293f54a3cd67b3, _ = codec
                _bind_f93a7605cd5e49e8b2293f54a3cd67b3
            
            let encode =
                let _, _bind_2141b13f91fb4f13b9f5489a7441b1c9 = codec
                _bind_2141b13f91fb4f13b9f5489a7441b1c9
            
            Fleece.Newtonsoft.jfield<TestAllTypes, List<Int32>, List<Int64> -> List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("repeatedSint32") (fun x -> x.repeatedSint32) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_5d2f6c739c6f4159a78040028c1fe6f1, _ = codec
                _bind_5d2f6c739c6f4159a78040028c1fe6f1
            
            let encode =
                let _, _bind_a176dcf90ad344bab0878aee0dfaadbc = codec
                _bind_a176dcf90ad344bab0878aee0dfaadbc
            
            Fleece.Newtonsoft.jfield<TestAllTypes, List<Int64>, List<UInt32> -> List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("repeatedSint64") (fun x -> x.repeatedSint64) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_1d5009afa1d7488ca2fe10517eeffb3b, _ = codec
                _bind_1d5009afa1d7488ca2fe10517eeffb3b
            
            let encode =
                let _, _bind_337266e9c9204e839283df6d7d5bd400 = codec
                _bind_337266e9c9204e839283df6d7d5bd400
            
            Fleece.Newtonsoft.jfield<TestAllTypes, List<UInt32>, List<UInt64> -> List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("repeatedFixed32") (fun x -> x.repeatedFixed32) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_a0012528ed9e43b985676d1ab60d0987, _ = codec
                _bind_a0012528ed9e43b985676d1ab60d0987
            
            let encode =
                let _, _bind_aae50734d12d4d9789303a81b9fc5f3a = codec
                _bind_aae50734d12d4d9789303a81b9fc5f3a
            
            Fleece.Newtonsoft.jfield<TestAllTypes, List<UInt64>, List<Int32> -> List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("repeatedFixed64") (fun x -> x.repeatedFixed64) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_a49774884d934b3e99d7d1570d8c1a4d, _ = codec
                _bind_a49774884d934b3e99d7d1570d8c1a4d
            
            let encode =
                let _, _bind_d99510280317486eb06c50ce4a262e2f = codec
                _bind_d99510280317486eb06c50ce4a262e2f
            
            Fleece.Newtonsoft.jfield<TestAllTypes, List<Int32>, List<Int64> -> List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("repeatedSfixed32") (fun x -> x.repeatedSfixed32) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_5b8b3637a2694b9e935b221f51e684dd, _ = codec
                _bind_5b8b3637a2694b9e935b221f51e684dd
            
            let encode =
                let _, _bind_981b650c149647408c5b0fb4411f0cf3 = codec
                _bind_981b650c149647408c5b0fb4411f0cf3
            
            Fleece.Newtonsoft.jfield<TestAllTypes, List<Int64>, List<Single> -> List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("repeatedSfixed64") (fun x -> x.repeatedSfixed64) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_8cacb0501c34438c8452f56e274ff8aa, _ = codec
                _bind_8cacb0501c34438c8452f56e274ff8aa
            
            let encode =
                let _, _bind_e7cf89b132ab465f87d703362ed6e4c5 = codec
                _bind_e7cf89b132ab465f87d703362ed6e4c5
            
            Fleece.Newtonsoft.jfield<TestAllTypes, List<Single>, List<Double> -> List<Boolean> -> List<String> -> TestAllTypes> 
                ("repeatedFloat") (fun x -> x.repeatedFloat) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_f8dab6332b1e45ea9fc9f41d66a857c6, _ = codec
                _bind_f8dab6332b1e45ea9fc9f41d66a857c6
            
            let encode =
                let _, _bind_f6035eb6145e4d2daae39c4d4bf200c9 = codec
                _bind_f6035eb6145e4d2daae39c4d4bf200c9
            
            Fleece.Newtonsoft.jfield<TestAllTypes, List<Double>, List<Boolean> -> List<String> -> TestAllTypes> 
                ("repeatedDouble") (fun x -> x.repeatedDouble) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_9f8775b7e71345bda949d86c7e4bbb26, _ = codec
                _bind_9f8775b7e71345bda949d86c7e4bbb26
            
            let encode =
                let _, _bind_611c2841189a47e4b715d003f9a682a5 = codec
                _bind_611c2841189a47e4b715d003f9a682a5
            
            Fleece.Newtonsoft.jfield<TestAllTypes, List<Boolean>, List<String> -> TestAllTypes> ("repeatedBool") 
                (fun x -> x.repeatedBool) (decode, encode)
        |> fun codec -> 
            let decode =
                let _bind_cdaa8c8a258c463cb4210b2b6caf1057, _ = codec
                _bind_cdaa8c8a258c463cb4210b2b6caf1057
            
            let encode =
                let _, _bind_6e6d1981cae34d82aa733cf4ce4b419d = codec
                _bind_6e6d1981cae34d82aa733cf4ce4b419d
            
            Fleece.Newtonsoft.jfield<TestAllTypes, List<String>, TestAllTypes> ("repeatedString") 
                (fun x -> x.repeatedString) (decode, encode)
    
    static member Serialize(m : TestAllTypes, buffer : ZeroCopyBuffer) =
        Primitives.writeOption<Int32> (Primitives.writeInt32) (1) (buffer) (m.singleInt32)
        Primitives.writeOption<Int64> (Primitives.writeInt64) (2) (buffer) (m.singleInt64)
        Primitives.writeOption<UInt32> (Primitives.writeUInt32) (3) (buffer) (m.singleUint32)
        Primitives.writeOption<UInt64> (Primitives.writeUInt64) (4) (buffer) (m.singleUint64)
        Primitives.writeOption<Int32> (Primitives.writeSInt32) (5) (buffer) (m.singleSint32)
        Primitives.writeOption<Int64> (Primitives.writeSInt64) (6) (buffer) (m.singleSint64)
        Primitives.writeOption<UInt32> (Primitives.writeFixed32) (7) (buffer) (m.singleFixed32)
        Primitives.writeOption<UInt64> (Primitives.writeFixed64) (8) (buffer) (m.singleFixed64)
        Primitives.writeOption<Int32> (Primitives.writeSFixed32) (9) (buffer) (m.singleSfixed32)
        Primitives.writeOption<Int64> (Primitives.writeSFixed64) (10) (buffer) (m.singleSfixed64)
        Primitives.writeOption<Single> (Primitives.writeFloat) (11) (buffer) (m.singleFloat)
        Primitives.writeOption<Double> (Primitives.writeDouble) (12) (buffer) (m.singleDouble)
        Primitives.writeOption<Boolean> (Primitives.writeBool) (13) (buffer) (m.singleBool)
        Primitives.writeOption<String> (Primitives.writeString) (14) (buffer) (m.singleString)
        Primitives.writeRepeated<Int32> (Primitives.writeInt32) (31) (buffer) (m.repeatedInt32)
        Primitives.writeRepeated<Int64> (Primitives.writeInt64) (32) (buffer) (m.repeatedInt64)
        Primitives.writeRepeated<UInt32> (Primitives.writeUInt32) (33) (buffer) (m.repeatedUint32)
        Primitives.writeRepeated<UInt64> (Primitives.writeUInt64) (34) (buffer) (m.repeatedUint64)
        Primitives.writeRepeated<Int32> (Primitives.writeSInt32) (35) (buffer) (m.repeatedSint32)
        Primitives.writeRepeated<Int64> (Primitives.writeSInt64) (36) (buffer) (m.repeatedSint64)
        Primitives.writeRepeated<UInt32> (Primitives.writeFixed32) (37) (buffer) (m.repeatedFixed32)
        Primitives.writeRepeated<UInt64> (Primitives.writeFixed64) (38) (buffer) (m.repeatedFixed64)
        Primitives.writeRepeated<Int32> (Primitives.writeSFixed32) (39) (buffer) (m.repeatedSfixed32)
        Primitives.writeRepeated<Int64> (Primitives.writeSFixed64) (40) (buffer) (m.repeatedSfixed64)
        Primitives.writeRepeated<Single> (Primitives.writeFloat) (41) (buffer) (m.repeatedFloat)
        Primitives.writeRepeated<Double> (Primitives.writeDouble) (42) (buffer) (m.repeatedDouble)
        Primitives.writeRepeated<Boolean> (Primitives.writeBool) (43) (buffer) (m.repeatedBool)
        Primitives.writeRepeated<String> (Primitives.writeString) (44) (buffer) (m.repeatedString)
    
    static member Deserialize(buffer : ZeroCopyBuffer) = Primitives.deserialize<TestAllTypes> (buffer)
    interface IMessage with
        member x.Serialize(buffer : ZeroCopyBuffer) = TestAllTypes.Serialize(x, buffer)
        
        member x.ReadFrom(buffer : ZeroCopyBuffer) =
            let enumerator : IEnumerator<Froto.Serialization.Encoding.RawField> =
                ZeroCopyBuffer.allFields(buffer).GetEnumerator()
            while enumerator.MoveNext() do
                let current : Froto.Serialization.Encoding.RawField = enumerator.Current
                if current.FieldNum = 44 then 
                    if Operators.isNull<List<String>> (x.repeatedString) then x.repeatedString <- new List<String>()
                    else ()
                    x.repeatedString.Add(Primitives.readString current)
                else if current.FieldNum = 43 then 
                    if Operators.isNull<List<Boolean>> (x.repeatedBool) then x.repeatedBool <- new List<Boolean>()
                    else ()
                    x.repeatedBool.Add(Primitives.readBool current)
                else if current.FieldNum = 42 then 
                    if Operators.isNull<List<Double>> (x.repeatedDouble) then x.repeatedDouble <- new List<Double>()
                    else ()
                    x.repeatedDouble.Add(Primitives.readDouble current)
                else if current.FieldNum = 41 then 
                    if Operators.isNull<List<Single>> (x.repeatedFloat) then x.repeatedFloat <- new List<Single>()
                    else ()
                    x.repeatedFloat.Add(Primitives.readFloat current)
                else if current.FieldNum = 40 then 
                    if Operators.isNull<List<Int64>> (x.repeatedSfixed64) then x.repeatedSfixed64 <- new List<Int64>()
                    else ()
                    x.repeatedSfixed64.Add(Primitives.readSFixed64 current)
                else if current.FieldNum = 39 then 
                    if Operators.isNull<List<Int32>> (x.repeatedSfixed32) then x.repeatedSfixed32 <- new List<Int32>()
                    else ()
                    x.repeatedSfixed32.Add(Primitives.readSFixed32 current)
                else if current.FieldNum = 38 then 
                    if Operators.isNull<List<UInt64>> (x.repeatedFixed64) then x.repeatedFixed64 <- new List<UInt64>()
                    else ()
                    x.repeatedFixed64.Add(Primitives.readFixed64 current)
                else if current.FieldNum = 37 then 
                    if Operators.isNull<List<UInt32>> (x.repeatedFixed32) then x.repeatedFixed32 <- new List<UInt32>()
                    else ()
                    x.repeatedFixed32.Add(Primitives.readFixed32 current)
                else if current.FieldNum = 36 then 
                    if Operators.isNull<List<Int64>> (x.repeatedSint64) then x.repeatedSint64 <- new List<Int64>()
                    else ()
                    x.repeatedSint64.Add(Primitives.readSInt64 current)
                else if current.FieldNum = 35 then 
                    if Operators.isNull<List<Int32>> (x.repeatedSint32) then x.repeatedSint32 <- new List<Int32>()
                    else ()
                    x.repeatedSint32.Add(Primitives.readSInt32 current)
                else if current.FieldNum = 34 then 
                    if Operators.isNull<List<UInt64>> (x.repeatedUint64) then x.repeatedUint64 <- new List<UInt64>()
                    else ()
                    x.repeatedUint64.Add(Primitives.readUInt64 current)
                else if current.FieldNum = 33 then 
                    if Operators.isNull<List<UInt32>> (x.repeatedUint32) then x.repeatedUint32 <- new List<UInt32>()
                    else ()
                    x.repeatedUint32.Add(Primitives.readUInt32 current)
                else if current.FieldNum = 32 then 
                    if Operators.isNull<List<Int64>> (x.repeatedInt64) then x.repeatedInt64 <- new List<Int64>()
                    else ()
                    x.repeatedInt64.Add(Primitives.readInt64 current)
                else if current.FieldNum = 31 then 
                    if Operators.isNull<List<Int32>> (x.repeatedInt32) then x.repeatedInt32 <- new List<Int32>()
                    else ()
                    x.repeatedInt32.Add(Primitives.readInt32 current)
                else if current.FieldNum = 14 then 
                    x.singleString <- (Some(Primitives.readString current) : Option<String>)
                else if current.FieldNum = 13 then x.singleBool <- (Some(Primitives.readBool current) : Option<Boolean>)
                else if current.FieldNum = 12 then 
                    x.singleDouble <- (Some(Primitives.readDouble current) : Option<Double>)
                else if current.FieldNum = 11 then 
                    x.singleFloat <- (Some(Primitives.readFloat current) : Option<Single>)
                else if current.FieldNum = 10 then 
                    x.singleSfixed64 <- (Some(Primitives.readSFixed64 current) : Option<Int64>)
                else if current.FieldNum = 9 then 
                    x.singleSfixed32 <- (Some(Primitives.readSFixed32 current) : Option<Int32>)
                else if current.FieldNum = 8 then 
                    x.singleFixed64 <- (Some(Primitives.readFixed64 current) : Option<UInt64>)
                else if current.FieldNum = 7 then 
                    x.singleFixed32 <- (Some(Primitives.readFixed32 current) : Option<UInt32>)
                else if current.FieldNum = 6 then 
                    x.singleSint64 <- (Some(Primitives.readSInt64 current) : Option<Int64>)
                else if current.FieldNum = 5 then 
                    x.singleSint32 <- (Some(Primitives.readSInt32 current) : Option<Int32>)
                else if current.FieldNum = 4 then 
                    x.singleUint64 <- (Some(Primitives.readUInt64 current) : Option<UInt64>)
                else if current.FieldNum = 3 then 
                    x.singleUint32 <- (Some(Primitives.readUInt32 current) : Option<UInt32>)
                else if current.FieldNum = 2 then x.singleInt64 <- (Some(Primitives.readInt64 current) : Option<Int64>)
                else if current.FieldNum = 1 then x.singleInt32 <- (Some(Primitives.readInt32 current) : Option<Int32>)
                else ()
            enumerator.Dispose()
        
        member x.SerializedLength() = Primitives.serializedLength<TestAllTypes> (x)
