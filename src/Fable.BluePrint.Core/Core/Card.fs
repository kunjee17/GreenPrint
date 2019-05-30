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
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Card =
    let inline card (props : ICardProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "Card" "@blueprintjs/core" props elems
