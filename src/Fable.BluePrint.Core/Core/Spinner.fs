namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module Spinner =
    [<Literal>]
    let SIZE_SMALL = 24

    [<Literal>]
    let SIZE_STANDARD = 50

    [<Literal>]
    let SIZE_LARGE = 100

    type ISpinnerProps =
        | ClassName of string
        | Intent of Intent
        | Size of int
        | TagName of obj
        | Value of int

    let inline spinner (props : ISpinnerProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Spinner" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
