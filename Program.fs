open System
open Suave

[<EntryPoint>]
let main argv =
    startWebServer defaultConfig (Successful.OK "Hello there, this is Chia-Sheng!")
    0
