open System

let [| n; k |] = stdin.ReadLine().Split(' ') |> Array.map int
let str = stdin.ReadLine()

str
|> String.mapi (fun i s ->
       if i = k - 1 then Char.ToLower s
       else s)
|> printfn "%s"
