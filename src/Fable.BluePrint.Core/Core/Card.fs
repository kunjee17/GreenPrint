namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props
open Browser.Types

open Fable.Core.JsInterop

type ICardProps =
    | ClassName of string
    | Elevation of Elevation
    | Interactive of bool
    | OnClick of (MouseEvent -> unit)
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Card =
    let inline card (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Card" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
