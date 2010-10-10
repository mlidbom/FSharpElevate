let describeHoleCards holeCards = 
    match holeCards with
    | (14, 14) -> "Pocket Rockets"
    | (13, 13) -> "Cowboys"
    | (11, 11) | (12, 12) -> "Pair of face cards"    
    | (2,2) -> "Ducks"
    | (x, y) when x = y -> sprintf "A pair of %is" x
    | (_,_) -> "nothing much"
    //note:
    //Multiple matches can give the same result
    //_ Matches any value
    //named patterns such as x, y capture values for use 

let ducks = describeHoleCards (2,2)
let nothingMuch = describeHoleCards (4,7)
let pairOf4s = describeHoleCards (4,4)
let pocketRockets = describeHoleCards (14,14)