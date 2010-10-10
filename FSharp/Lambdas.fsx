let bounce x = x
//Exactly Equivalent to:
let lbounce = fun x -> x

let add a b = a + b
//Exactly Equivalent to:
let lAdd = fun a -> fun b -> a + b

let two = add 1 1
let lTwo = lAdd 1 1


