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
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Spinner =
    [<Literal>]
    let SIZE_SMALL = 24

    [<Literal>]
    let SIZE_STANDARD = 50

    [<Literal>]
    let SIZE_LARGE = 100

    let inline spinner (props : ISpinnerProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "Spinner" "@blueprintjs/core" props elems
