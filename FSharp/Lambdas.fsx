let bounce x = x
//Exactly Equivalent to:
let lbounce = fun x -> x

let tuple2 a b = (a, b)
//Exactly Equivalent to:
let ltuple2 = fun a -> fun b -> (a, b)

let oneAndTwo = tuple2 1 2
let loneAndTwo = ltuple2 1 2

let truth = oneAndTwo = loneAndTwo

