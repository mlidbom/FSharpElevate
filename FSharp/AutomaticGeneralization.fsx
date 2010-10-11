//Did you notice?
//Generic
//Fully type safe
let bounce x = x

//bounce int
let one = bounce 1

//bounce float
let oneDotOne = bounce 1.1

//type annotations can be used when inference fails
let bounceInt (x:int) = x

