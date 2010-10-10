//Adds type safety to simple types.
//A method that expects meters will not accept a parameter of type second etc etc
[<Measure>]
type second

[<Measure>]
type meter

//Measures combine as you manipulate values
[<Measure>]
type velocity = meter / second

[<Measure>]
type acceleration = meter / second ^ 2


let height = 3.<meter>
let earthAcceleration = 9.82<meter/second^2>
let time = 3.<second>
let speed = time * earthAcceleration
