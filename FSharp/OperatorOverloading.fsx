
type Vector = 
    {X : int; Y:int}
    static member (+) (lhs, rhs) = { X= lhs.X + rhs.X; 
                                     Y = lhs.Y + rhs.Y}

let oneThirty = {X=0; Y=1} + {X=1; Y=0}
