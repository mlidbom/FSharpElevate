//Black jack now...
type Suit = 
    | Spades
    | Hearts    
    | Diamonds
    | Clubs

type Card = 
    | Ace of Suit
    | King of Suit
    | Queen of Suit
    | Jack of Suit
    | ValueCard of Suit * int

    //Static member
    static member value this = 
        match this with
        | Ace(_) -> 11
        | King(_) | Queen(_) | Jack(_) -> 10
        | ValueCard(_, value) -> value

    //Ordinary member delegates to static member so you have the choice of functional or OO style usage
    member this.Value = Card.value this


//Here ordinary member is easier        
let eleven = Ace(Spades).Value
let elevenAgain = Card.value (Ace(Spades))


let hand = [Ace(Spades); King(Hearts) ; Queen(Diamonds)]

//Here static function is easier
let handSum = hand |> List.sumBy Card.value 
let handSumAgain = hand |> List.sumBy (fun x -> x.Value)