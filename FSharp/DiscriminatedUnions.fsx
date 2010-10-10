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
    | ValueCard of int * Suit

let aceOfSpades = Ace(Spades)
let fourOfClubs = ValueCard(4, Clubs)

let straightFlush = (King(Spades), 
                     Queen(Spades), 
                     Jack(Spades), 
                     ValueCard(10, Spades),
                     ValueCard(9, Spades))

