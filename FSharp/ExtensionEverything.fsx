module CollectionExtensions =
  //Extension method
  type System.String with
    member this.IsNullOrEmpty() = System.String.IsNullOrEmpty this
    
    //Static extension method
    static member MyLength (aString:string) = aString.Length

    //Extension property  
    member this.NumberOfAs with get() = this |> Seq.filter (fun c -> c = 'a') |> Seq.length



open CollectionExtensions
open System

let two = "aoeua".NumberOfAs
let truth = "".IsNullOrEmpty()

let five = String.MyLength "abcde"
