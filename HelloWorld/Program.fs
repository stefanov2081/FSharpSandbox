// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System


let printGreeting name = 
    printfn "Hello %s from F#!" name

[<EntryPoint>]
let main argv =
    printGreeting "World"
    
    0