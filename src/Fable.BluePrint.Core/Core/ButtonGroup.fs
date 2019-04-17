namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

type IButtonGroupProps =
    | AlignText of AlignText
    | ClassName of string
    | Fill of bool
    | Large of bool
    | Minimal of bool
    | Vertical of bool
    interface IHTMLProp

[<RequireQualifiedAccess>]
module ButtonGroup =
    let inline buttonGroup (props : IHTMLProp list)
               (elems : ReactElement list) : ReactElement =
        ofImport "ButtonGroup" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
