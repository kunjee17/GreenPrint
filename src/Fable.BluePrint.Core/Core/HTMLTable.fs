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
    interface IHTMLProp

[<RequireQualifiedAccess>]
module HTMLTable =
    let inline htmlTable (props : IHTMLProp list)
               (elems : ReactElement list) : ReactElement =
        ofImport "HTMLTable" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
