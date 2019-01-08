namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module ButtonGroup =

    type IButtonGroupProps =
        | AlignText of AlignText
        | ClassName of string
        | Fill of bool
        | Large of bool
        | Minimal of bool
        | Vertical of bool

    let inline buttonGroup (props : IButtonGroupProps list) (elems : ReactElement list) : ReactElement =
        ofImport "ButtonGroup" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
