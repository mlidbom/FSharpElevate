#r "FSharp.PowerPack.Parallel.Seq.dll"
open Microsoft.FSharp.Collections

let divisibleBy x y = x % y = 0

let isPrime x = x > 2 && seq{2..(x-1)} |> Seq.forall (not << (divisibleBy x) )

let primesBelow x = seq{3..x} |> Seq.filter isPrime |> Seq.length

let threadedPrimesBelow x = seq{3..x} |> PSeq.filter isPrime |> PSeq.length


//Util method to do timings:
open System.Diagnostics
let time f x =     
    let watch = new Stopwatch()
    watch.Start()
    let result = f x
    result, watch.ElapsedMilliseconds

for i in 1..4 do
    let single, singleTime = time primesBelow 20000  
    let threaded, threadedTime = time threadedPrimesBelow 20000    
    let factor = double singleTime / double threadedTime
    printfn "Threaded version %f times faster than single threaded version" factor