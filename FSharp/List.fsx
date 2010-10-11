//F# functional collection types
//Immutable
//Array the exception


//the list data type is an immutable singly linked list
//looking something like this...
type myList<'a> = 
    | Cons of 'a * myList<'a>
    | Nil
//Note the recursion!

//Combined with the List module and a 
//number of operators you get plenty of power
//From this very simple type

//declaration
let oneThroughFive = [1;2;3;4;5]

//the empty list0
let emptylist = []

//Ranges
let oneThroughTen = [1..10]

//With varying step length
let odds = [1..2..11]
let negativeOdds = [-1..-2..-11]

//cons prepends an element to a list
let oneThroughFour = 1::2::[3..4]

//Concatenation 
let oneThroughSix = [1..3] @ [4..6]

//Pattern matching
let rec sum lst = 
    match lst with
    | head::[] -> head
    | head::tail -> head + sum tail
    | [] -> failwith "Can't sum empty list"

let fifteen = sum oneThroughFive

//Comprehension
let squares = [for i in [1..10] do yield i * i]

//simplified
let squares2 = [for i in [1..10] -> i * i]

//List module

let small = List.filter (fun x -> x < 5) [1..10]
let squares3 = List.map (fun x -> x * x) [1..10]
//Lots and lots more functionality


//Seq == IEnumerable<T>
let small2 = Seq.filter (fun x -> x < 4) [1..9]