namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

type IProgressBarProps =
    | Animate of bool
    | ClassName of string
    | Intent of Intent
    | Stripes of bool
    | Value of float
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module ProgressBar =
    let inline progressBar (props : IProgressBarProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "ProgressBar" "@blueprintjs/core" props elems
