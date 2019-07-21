if 
    ((Seq.map (Seq.distinct >> Seq.length) (stdin.ReadLine()
    |> Seq.windowed 2))
    |> Seq.contains 1) then
    "Bad"
else
    "Good"
|>printfn "%s"
