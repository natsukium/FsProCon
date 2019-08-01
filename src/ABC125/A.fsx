let [| a; b; t |] = stdin.ReadLine().Split(' ') |> Array.map int

(t / a) * b |> printfn "%d"
