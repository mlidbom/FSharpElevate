
type IPrintable =
   abstract member Print : unit -> unit
   //member me.Hoho = 12 //add this and you have a class...

[<AbstractClassAttribute>]//Required for abstract classes
type AbstractPrintable(text) = //Constructor
    interface IPrintable with
        member me.Print() = printfn "%s" text |> ignore

    //Abstract method..
    abstract member DoSomething : unit -> unit

    //Read only property
    member me.Text = text;
    
    //Identical to more verbose:
    //member me.Text with get() = text;

    abstract member OverrideMe : unit -> unit
    //This is how you create "virtual" members in f#
    //provide a default implementation of the member
    default me.OverrideMe() = ()

[<SealedAttribute>]//No overriding
type PrintableVector(x:int, y: int) =
    //Note sprintf
    //sprintf is type safe!
    inherit AbstractPrintable(sprintf "An arry with X=%i and Y=%i" x y)

    //Override abstract method
    override this.DoSomething() = printfn "Doing Something" |> ignore

    //Notice how the Self Identifiers need not be named "Me" or "this" etc
    member you.X = x
    member me.Y = x

    override me.OverrideMe() = printfn "%s" "Overridden" |> ignore



let zenith = new PrintableVector(0, 1)

let one = zenith.Y
let zero = zenith.X

zenith.DoSomething()


//zenith.Print() does not compile!
//You have to cast to interface types.
(zenith :> IPrintable).Print();

//It's a safe cast though

