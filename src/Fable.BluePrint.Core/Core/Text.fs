namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

type ITextProps =
    | ClassName of string
    | Ellipsize of bool
    | TagName of obj
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Text =
    let inline text (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Text" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
