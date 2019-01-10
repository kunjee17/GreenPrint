namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module ControlGroup =

    type IControlGroupProps =
        | ClassName of string
        | Fill of bool
        | Vertical of bool

    let inline controlGroup (props : IControlGroupProps list) (elems : ReactElement list) : ReactElement =
        ofImport "ControlGroup" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
