namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

type ICardProps =
    | ClassName of string
    | Elevation of Elevation
    | Interactive of bool
    | OnClick of (MouseEvent -> unit)

[<RequireQualifiedAccess>]
module Card =
    let inline card (props : ICardProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Card" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
