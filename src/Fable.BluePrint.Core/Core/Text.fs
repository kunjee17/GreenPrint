namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

type ITextProps =
    | ClassName of string
    | Ellipsize of bool
    | TagName of obj
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Text =
    let inline text (props : ITextProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "Text" "@blueprintjs/core" props elems
