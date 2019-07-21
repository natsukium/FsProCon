let str = stdin.ReadLine()
 
let has2char =
    str
    |> Seq.distinct
    |> Seq.length
    |> (=) 2
 
let isTwice =
    str
    |> Seq.sort
    |> Seq.tail
    |> Seq.take 2
    |> Seq.distinct
    |> Seq.length
    |> (=) 2
 
if has2char && isTwice then "Yes" else "No"
|> printfn "%s"
