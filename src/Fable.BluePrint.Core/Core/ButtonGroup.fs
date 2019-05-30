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
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module ButtonGroup =
    let inline buttonGroup (props : IButtonGroupProps list)
               (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "ButtonGroup" "@blueprintjs/core" props elems
