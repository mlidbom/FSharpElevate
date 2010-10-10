let add a b = a + b
//let add = fun a -> fun b -> a + b

//Curried function add1 adds 1 to its argument
let add1 = add 1
let two = add1 1

//Curried function add1 adds 1 to its argument
let add2 = add 2 
let three = add2 1

//Currying also called Partial Application

