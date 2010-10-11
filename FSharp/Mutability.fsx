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
    member this.X with get() = _x and set(newX) = _x <- newX
    
    //Pick your formatting poison
    member this.Y 
        with get() = _y 
        and set(newX) = _y <- newX
