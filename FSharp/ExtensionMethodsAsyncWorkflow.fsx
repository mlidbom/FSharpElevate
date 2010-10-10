#r "FSharp.PowerPack.dll"

open System.IO
open System.Net
open Microsoft.FSharp.Control.CommonExtensions 

//Extension method...
type System.Net.WebRequest with
  member x.GetResponseAsync() =
    Async.FromBeginEnd(x.BeginGetResponse, x.EndGetResponse)

let getHtml (url:string) =        
      async { let request = WebRequest.Create(url) 
              use! response = request.GetResponseAsync()
              use stream = response.GetResponseStream() 
              use reader = new StreamReader(stream) 
              return! reader.AsyncReadToEnd() 
            }
            
let url = "http://www.sunet.se"

let downloadUrls() = 
    async{
        let! url1 = getHtml url
        let! url2 = getHtml url
        let! url3 = getHtml url
        let! url4 = getHtml url
        let! url5 = getHtml url
        let! url6 = getHtml url
        return ()
    } |> Async.RunSynchronously

downloadUrls()

