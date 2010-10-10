//Did you notice?
//Generic
//Fully type safe
let bounce x = x

//bounce int
let one = bounce 1

//bounce float
let oneDotOne = bounce 1.1

//in c#  
//T bounce<T>(T x)
//{ 
//   return x;
//}
//
//Damn that feels noisy
//when getting used to F# syntax

//type annotations can be used when inference fails
let bounceInt (x:int) = x

