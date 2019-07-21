stdin.ReadLine().Split(' ')
|> Array.map int
|> Seq.sort
|> Seq.take 2
|> Seq.sum
|> printfn "%d"
