let [| r; d; x |] = stdin.ReadLine().Split(' ') |> Array.map int

let rec getWeights cnt prev xs =
    match cnt with
    | 0 -> List.rev xs
    | _ ->
        let present = r * prev - d
        getWeights (cnt - 1) present (present :: xs)

getWeights 10 x [] |> List.iter (printfn "%d")
