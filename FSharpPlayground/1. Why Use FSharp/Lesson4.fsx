let rec quicksort list =
    match list with
    | [] -> []                         
    | first::remainder ->              
        let a = remainder |> List.filter (fun e->e < first) 
        let z = remainder |> List.filter (fun e->e >= first) 
        List.concat [quicksort a; [first]; quicksort z]

let ans = quicksort [1;5;23;18;9;1;3]


    
let rec quicksort2 list = 
    match list with
    | [] -> []                         
    | first::remainder ->              
        let a,z = List.partition ((>=) first) remainder
        List.concat [quicksort2 a; [first]; quicksort2 z]

let ans2 = quicksort2 [1;5;23;18;9;1;3]

let rec quicksort3 = function
    | [] -> []                         
    | first::remainder ->              
        let a,z = List.partition ((>=) first) remainder
        List.concat [quicksort3 a; [first]; quicksort3 z]

let ans3 = quicksort3 [1;5;23;18;9;1;3]

ans2
ans3
