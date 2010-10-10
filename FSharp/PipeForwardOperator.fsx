//You can use operator overloading with function types!
//Actually comes with F# but you can declare it if you wish
let (|>) x f = f x

let even x = x % 2 = 0
let lessThan5 x = x < 5

//Inverted nesting easy reading make not does
let wtf = List.filter 
            even 
            (List.rev 
                (List.filter 
                    lessThan5 
                    [1..10]))

//Sequential code without temporary variables though...
let understandable = 
    [1..10] 
    |> List.filter lessThan5
    |> List.rev 
    |> List.filter even


