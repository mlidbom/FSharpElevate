﻿

type Person = 
      { Forename : string; 
        Surname : string; }
      
        member this.Description = 
            match this with
            | {Forename = "Magnus"; Surname = "Lidbom"} -> "Me"
            | {Forename = "Lars"; Surname = "Lidbom"} -> "Pops"
            | {Forename = foreName; Surname ="Lidbom"} -> sprintf "Some relative named %s" foreName
            | x -> sprintf "%s %s" x.Forename x.Surname

let someDude = {Forename = "Joe"; Surname = "Doe" }.Description
let someRelative = {Forename = "Joe"; Surname = "Lidbom" }.Description