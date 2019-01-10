namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

type ITextProps =
    | ClassName of string
    | Ellipsize of bool
    | TagName of obj

[<RequireQualifiedAccess>]
module Text =
    let inline text (props : ITextProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Text" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
