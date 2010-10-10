
//In languages such as C# null is ambiguous. No value vs uninitialized
//F# created types do not allow null values
//The option type removes any ambiguity

//module Option=
//    type 'a option =
//    | None
//    | Some of 'a

type Person(name:string, father : Person option) = 
    member this.Father = father
    member this.Name = name

let me = new Person("Magnus", Some(new Person("Lars", None)))
let orphan = new Person("Orpan", None)

//Using option forces exlicit dealing with missing values
let describeFather (per:Person) = 
    match per.Father with
    | Some(father) -> sprintf "Father: %s" father.Name
    | None -> "Father unknown"

describeFather me
describeFather orphan

