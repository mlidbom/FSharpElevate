#r "FSharp.PowerPack.Parallel.Seq.dll"
open Microsoft.FSharp.Collections

let divisibleBy x y = x % y = 0

let isPrime x = x > 2 && seq{2..(x-1)} |> Seq.forall (not << (divisibleBy x) )

let primesBelow x = seq{3..x} |> Seq.filter isPrime |> Seq.length

let threadedPrimesBelow x = seq{3..x} |> PSeq.filter isPrime |> PSeq.length


//#time;;
let single = primesBelow 20000  
let threaded = threadedPrimesBelow 20000