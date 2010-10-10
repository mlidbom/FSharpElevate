//Backward composition operator
//Actually comes with F# but you can declare it if you wish
let (<<) f g x = f(g x)

let largerThan5 x = x > 5
let smallerThan6 = not << largerThan5

//Forward composition operator
//Actually comes with F# but you can declare it if you wish
let (>>) f g x = g(f x)

let smallerThan6Again = largerThan5 >> not

let t1 = largerThan5 6
let f1 = largerThan5 5

let t2 = smallerThan6 5
let f2 = smallerThan6 6

let t3 = smallerThan6Again 5
let f3 = smallerThan6Again 6