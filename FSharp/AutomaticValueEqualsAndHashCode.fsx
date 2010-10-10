//Did you notice?
let truth = (1, 2) = (1, 2)

let alsotruth = ((1, 2),2,(3.2, "Hi there")) = ((1, 2),2,(3.2, "Hi there"))
let lie = ((1, 2),2,(3.2, "Hi there")) = ((1, 2),2,(3.2, "Hi up there"))

//Equals here works correctly as expected
//Automatically implemented by compiler 
//along with hashcode. 

//Same goes for the Discriminated union
//and Record types that we will be talking about 
//soon
