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

    member this.Value = 
        match this with
        | Ace(_) -> 11
        | King(_) | Queen(_) | Jack(_) -> 10
        | ValueCard(_, value) -> value

let eleven = Ace(Spades).Value
let eight = ValueCard(Hearts, 8).Value