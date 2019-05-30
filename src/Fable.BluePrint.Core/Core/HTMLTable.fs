namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

type IHTMLTableProps =
    | Bordered of bool
    | Condensed of bool
    | ElementRef of (obj -> unit)
    | Interactive of bool
    | Striped of bool
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module HTMLTable =
    let inline htmlTable (props : IHTMLTableProps list)
               (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "HTMLTable" "@blueprintjs/core" props elems
