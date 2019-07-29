let s =
    stdin.ReadLine()
    |> Seq.map (fun c -> int c - 48)
    |> Seq.toList

let rec countChange cnt prev xs =
    match xs with
    | x :: xs ->
        if x = prev then
            countChange (cnt + 1) (if x = 1 then 0
                                   else 1) xs
        else countChange cnt x xs
    | _ -> cnt

min (countChange 0 -1 s) (countChange 0 -1 (s |> List.rev)) |> printfn "%d"
