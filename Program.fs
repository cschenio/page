open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful

let addTwoString n = sprintf "2 + %d = %d" n (n + 2)

let powOfTwoString n = sprintf "2 ^ %d = %d" n (pown 2 n)

[<EntryPoint>]
let main argv =

    let n = 6

    let app =
        choose
            [ GET >=> choose
                          [ path "/pow" >=> OK(powOfTwoString n)
                            path "/add" >=> OK(addTwoString n) ] ]

    startWebServer defaultConfig app
    0
