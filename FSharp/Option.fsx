
//F# types do not allow null values

module Option=
    type 'a option =
    | None
    | Some of 'a

    let isNone = function
        | None -> true
        | Some(_) -> false

    let isSome = function
        | Some(_) -> true
        | None -> false

    let value = function
        | Some(value) -> value
        | None -> failwith "Option is none"






