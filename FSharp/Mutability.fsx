//Local variables
let mutable x = 5
let five = x
x <- 7
let seven = x

//Classes
type MutableArray(x:int, y:int) =
    let mutable _x = x
    let mutable _y = y

    //Get set properties
    member this.X with get() = _x and set newX = _x <- newX
    
    //Pick your formatting poison
    member this.Y 
        with get() = _y 
        and set newX = _y <- newX

let variable = new MutableArray(1,2)

let one = variable.X
let two = variable.Y

variable.X <- 3
let three =variable.X

//Records
type Vec2 = { mutable X : int; mutable Y: int}

let temp = { X=1; Y=1}
temp.X <- 2
temp.Y <-2