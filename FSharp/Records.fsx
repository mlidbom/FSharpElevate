
type Person = { Forename : string; 
                Surname : string; }

//Easy creation
let me = { Forename = "Magnus"; Surname = "Lidbom"; }

//Easy cloning with modifications
let dad =  { me with Forename = "Lars" }

//Pattern matching supported
let describePerson person = 
    match person with
    | {Forename = "Magnus"; Surname = "Lidbom"} -> "Me"
    | {Forename = "Lars"; Surname = "Lidbom"} -> "Pops"
    | {Forename = foreName; Surname ="Lidbom"} -> sprintf "Some relative named %s" foreName
    | x -> sprintf "%s %s" x.Forename x.Surname

let someDude = describePerson {Forename = "Joe"; Surname = "Doe" }
let someRelative = describePerson {Forename = "Joe"; Surname = "Lidbom" }

