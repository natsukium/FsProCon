let [| a; b |] = stdin.ReadLine().Split(' ') |> Array.map int

if a = b then a * 2
else (max a b) * 2 - 1
|> printfn "%d"
