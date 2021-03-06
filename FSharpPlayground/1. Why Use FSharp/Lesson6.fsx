﻿let square x = x * x

// functions as values
let squareclone = square
let result = [1..10] |> List.map squareclone

// functions taking other functions as parameters
let execFunction aFunc aParam = aFunc aParam
let result2 = execFunction square 12

type IntAndBool = {intPart: int; boolPart: bool}

//use it
let x = {intPart=1; boolPart=false}

//declare it
type IntOrBool = 
  | IntChoice of int
  | BoolChoice of bool

//use it
let y = IntChoice 42
let z = BoolChoice true


type Shape =        // define a "union" of alternative structures
    | Circle of radius:int 
    | Rectangle of height:int * width:int
    | Point of x:int * y:int 
    | Polygon of pointList:(int * int) list

let draw shape =    // define a function "draw" with a shape param
  match shape with
  | Circle radius -> 
      printfn "The circle has a radius of %d" radius
  | Rectangle (height,width) -> 
      printfn "The rectangle is %d high by %d wide" height width
  | Polygon points -> 
      printfn "The polygon is made of these points %A" points
  | _ -> printfn "I don't recognize this shape"

let circle = Circle(10)
let rect = Rectangle(4,5)
let point = Point(2,3)
let polygon = Polygon( [(1,1); (2,2); (3,3)])

[circle; rect; polygon; point] |> List.map draw