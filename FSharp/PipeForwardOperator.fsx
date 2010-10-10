//You can use operator overloading with function types!
//Actually comes with F# but you can declare it if you wish
let (|>) x f = f x

let wtf = List.filter (fun x -> x % 2 = 0) 
                (List.rev (List.filter (fun x -> x < 5) 
                    [1..10]))


let understandable = 
    [1..10] 
    |> List.filter (fun x -> x < 5) 
    |> List.rev 
    |> List.filter (fun x -> x % 2 = 0)


