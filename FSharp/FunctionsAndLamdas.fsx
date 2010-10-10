
let add x y = x + y
let add2 = add 2
let four = add2 2

let add_raw = fun x -> fun y -> x + y


let print_any x = printfn "%A" x

let print_matching condition collection = 
    collection 
    |> Seq.filter condition 
    |> Seq.iter print_any

   
let oneThroughFive = [1..5]
let largerThan2 x = x > 2 

print_matching largerThan2 oneThroughFive