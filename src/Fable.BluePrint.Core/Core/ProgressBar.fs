namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module ProgressBar =

    type IProgressBarProps =
        | Animate of bool
        | ClassName of string
        | Intent of Intent
        | Stripes of bool
        | Value of float

    let inline progressBar (props : IProgressBarProps list) (elems : ReactElement list) : ReactElement =
        ofImport "ProgressBar" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
