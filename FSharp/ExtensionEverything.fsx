module CollectionExtensions =
  //Extension method
  type System.String with
    member this.IsNullOrEmpty() = System.String.IsNullOrEmpty this
    
    //Static extension method
    static member MyLength (aString:string) = aString.Length

    //Extension property  
    member this.NumberOfAs with 
        get() = this |> Seq.filter (fun c -> c = 'a') |> Seq.length
        and set(huhu) = ignore <| huhu //Now this is pretty silly....



open CollectionExtensions
open System

let two = "aoeua".NumberOfAs
let a = "a"

a.NumberOfAs <- 12//Now this is pretty silly....


let truth = "".IsNullOrEmpty()
let lie = "a".IsNullOrEmpty()

let five = String.MyLength "abcde"


