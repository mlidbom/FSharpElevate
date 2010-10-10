let divisibleBy x y = x % y = 0

let isPrime x = 
    x > 2 && 
    seq{2..(x-1)} 
    |> Seq.forall (not << (divisibleBy x) )


let truth = isPrime 3
let nope = isPrime 15