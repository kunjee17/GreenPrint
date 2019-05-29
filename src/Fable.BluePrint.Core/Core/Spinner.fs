namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

type ISpinnerProps =
    | ClassName of string
    | Intent of Intent
    | Size of int
    | TagName of obj
    | Value of int
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Spinner =
    [<Literal>]
    let SIZE_SMALL = 24

    [<Literal>]
    let SIZE_STANDARD = 50

    [<Literal>]
    let SIZE_LARGE = 100

    let inline spinner (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Spinner" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
