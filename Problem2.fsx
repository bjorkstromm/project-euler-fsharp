let fib max =
    let rec loop x y xs =
        match (x + y) with
        | z when z > max -> xs |> List.rev
        | z -> z::xs |> loop y z
    loop 1 2 [2;1]

let isEven x =
    (x % 2) = 0

fib 4000000
|> Seq.filter isEven
|> Seq.sum