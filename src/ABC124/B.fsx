stdin.ReadLine() |> ignore

let hs =
    stdin.ReadLine().Split()
    |> Array.map int
    |> Array.toList

let rec countHotel cnt highest xs =
    match xs with
    | x :: xs ->
        if x >= highest then countHotel (cnt + 1) x xs
        else countHotel cnt highest xs
    | _ -> cnt

countHotel 0 0 hs |> printfn "%d"
