stdin.ReadLine() |> ignore

let vs = stdin.ReadLine().Split(' ') |> Array.map int
let cs = stdin.ReadLine().Split(' ') |> Array.map int

Array.map2 (-) vs cs
|> Array.filter (fun c -> c > 0)
|> Array.sum
|> printfn "%d"
