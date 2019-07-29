let [| a; b |] = stdin.ReadLine().Split(' ') |> Array.map int

match a with
| a when a <= 5 -> 0
| a when a <= 12 -> b / 2
| _ -> b
|> printfn "%d"
