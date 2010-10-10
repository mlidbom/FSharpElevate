let divisibleBy x y = x % y = 0

let isPrime x = 
    x > 2 && //By definition 2 is not prime
    seq{2..(x-1)} //All numbers less than x
    |> Seq.forall (not << (divisibleBy x) ) //Must not evenly divide x 


let truth = isPrime 3
let nope = isPrime 15