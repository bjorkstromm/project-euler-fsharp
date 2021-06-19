let rec getFactor n x xs =
    match (n % x) with
    | 0L when n = x -> x::xs
    | 0L -> getFactor (n/x) x (x::xs)
    | _ -> getFactor n (x+1L) xs

let factorise n = getFactor n 2L []

factorise 600851475143L |> List.max