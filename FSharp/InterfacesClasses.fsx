
type IPrintable =
   abstract member Print : unit -> unit
   //member me.Hoho = 12 //add this and you have a class...

[<AbstractClassAttribute>]//Required for abstract classes
type AbstractPrintable(text) = //Constructor
    interface IPrintable with
        member me.Print() = printf "%s" text |> ignore

    //Abstract method..
    abstract member DoSomething : unit -> unit
   
    //Read only property
    member me.Text with get() = text;


[<SealedAttribute>]//No overriding
type PrintableVector(x:int, y: int) =
    //Note sprintf
    //sprintf is type safe!
    inherit AbstractPrintable(sprintf "An arry with X=%i and Y=%i" x y)

    //Override abstract method
    override this.DoSomething() = printfn "Doing Something" |> ignore

    //Notice how the Self Identifiers need not be named "Me" or "this" etc
    member you.X with get() = x
    member me.Y with get() = x





