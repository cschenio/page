open System.IO

open Suave
open Suave.Filters
open Suave.Operators


[<EntryPoint>]
let main argv =
    let app: WebPart =
        choose
            [ GET >=> path "/" >=> Files.file "index.html"
              GET >=> Files.browseHome
              RequestErrors.NOT_FOUND "404 Page not found." ]

    let config = { defaultConfig with homeFolder = Some(Path.GetFullPath "./public") }

    startWebServer config app
    0
