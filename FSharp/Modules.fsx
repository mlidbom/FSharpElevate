//Modules can contain
//Types
//Value
//Other modules
module MyStuff =
    let square x = x * x
    let cube x = x * x * x

    module Nested =
        let One = 1


let twentySever = MyStuff.cube 3
let one = MyStuff.Nested.One



