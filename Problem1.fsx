let multipleOf y x =
    (x % y) = 0

let multipleOf3or5 x =
    (x |> multipleOf 3) || (x |> multipleOf 5)


[1..999]
|> Seq.filter multipleOf3or5
|> Seq.sum