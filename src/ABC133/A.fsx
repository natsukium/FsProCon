let input = stdin.ReadLine().Split(' ') |> Array.map int
let train = input.[0] * input.[1]
let taxi = input.[2]
 
if train < taxi then train else taxi
|> printfn "%d"
