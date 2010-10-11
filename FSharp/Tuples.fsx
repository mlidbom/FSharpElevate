//Declaration of a value. NOT assignment to a variable
let oneAndTwo = (1, 2) 

//Declare one and two as parts of the tuple
let one, two = oneAndTwo
//Note that this is one of many usages of pattern matching 
//Pattern matching will be covered later

//Extract single value from a tuple
let first = fst oneAndTwo
let second = snd oneAndTwo

