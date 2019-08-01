let s = stdin.ReadLine()
let f = int s.[0..1]
let b = int s.[2..3]
let isM x = x > 0 && x < 13

if isM f && isM b then "AMBIGUOUS"
elif isM f then "MMYY"
elif isM b then "YYMM"
else "NA"
|> printfn "%s"
