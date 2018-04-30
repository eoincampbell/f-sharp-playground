open System.Net
open System
open System.IO

let fetchUrl callback url = 
    let req = WebRequest.Create(Uri(url))
    use res = req.GetResponse()
    use stream = res.GetResponseStream()
    use reader = new StreamReader(stream)
    callback reader url

let myCallback (reader:StreamReader) url = 
    let html = reader.ReadToEnd()
    let html100 = html.Substring(0,100)
    printfn "Downloaded %s. First 100 is %s" url html100



let fetchUrl2 = fetchUrl myCallback

let google = fetchUrl2 "http://www.google.com"
let bbc = fetchUrl2 "http://www.bbc.co.uk"


let simpleFunction anotherFunction inputParam = 
    let concatval = "Input: " + inputParam
    anotherFunction concatval

let chainFunction inputParam = 
    let chainresult = "Nested: " + inputParam
    chainresult


let x = simpleFunction chainFunction "eoin"


let s2 = simpleFunction chainFunction


let sites = ["eoin"; "ronan"; "elaine"]

sites |> List.map s2
