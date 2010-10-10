#r "System.Xml.dll"
open System.Xml

type Part =
    | Widget of float
    | Sprocket of string * int

//Single case active pattern converts input
//Attributes return the element's attributes...
let (|Attributes|) (inp : XmlNode) = inp.Attributes

//Partial case active pattern returns an option type to determine match
//Elem returns matching XmlNode instances
let (|Elem|_|) name (inp:XmlNode) = 
    if inp.Name = name then Some(inp)
    else None

//extracts the value from an attribute
let (|Attr|) attrName (inp: XmlAttributeCollection) = 
    match inp.GetNamedItem(attrName) with
    | null -> failwithf "Attribute %s not found" attrName
    | attr -> attr.Value


let ParseXmlNode element = 
    //Parse a widget without nesting active patterns
    match element with
    | Elem "Widget" (Attributes (Attr "Diameter" diameter)) 
        -> Widget(float diameter)
    | Elem "Sprocket" (Attributes (Attr "Model" model & Attr "SerialNumber" sn))
        -> Sprocket(model, int sn)
    | _ -> failwith "Unknown element"

let xmlDoc =
    let doc = new XmlDocument()
    let xmlText = 
        "<?xml version=\"1.0\" encoding=\"utf-8\"?>
        <Parts>
            <Widget Diameter='5.0' />
            <Sprocket Model='A' SerialNumber='147' />
            <Sprocket Model='B' SerialNumber='302' />
        </Parts>
        "
    doc.LoadXml(xmlText)
    doc

xmlDoc.DocumentElement.ChildNodes |> Seq.cast<XmlElement> |> Seq.map ParseXmlNode

