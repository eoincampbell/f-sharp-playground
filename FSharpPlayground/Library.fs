namespace FSharpPlayground

module Say =
    let hello name =
        printfn "Hello %s" name


module MultiType =
    type IntOrBool = 
        | IntChoice of int
        | BoolChoice of bool

    let myFunc input = 
        match input with
            | true -> IntChoice 42
            | false -> BoolChoice false