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


//let google = fetchUrl myCallback "http://www.google.com"

//let fetch