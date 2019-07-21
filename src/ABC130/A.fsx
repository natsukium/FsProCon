let [| x; a |] = stdin.ReadLine().Split(' ') |> Array.map int

if x < a then 0
else 10
|> printfn "%d"
