let [| a; p |] = stdin.ReadLine().Split(' ') |> Array.map int

(a * 3 + p) / 2 |> printfn "%d"
