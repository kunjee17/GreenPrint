namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props
open Fable.Core.JsInterop

type ICheckboxProps =
    | AlignIndicator of Alignment
    | Checked of bool
    | Children of ReactElement
    | ClassName of string
    | DefaultChecked of bool
    | DefaultIndeterminate of bool
    | Disabled of bool
    | Indeterminate of bool
    | Inline of bool
    | InputRef of (ReactElement -> obj)
    | Label of string
    | LabelElement of ReactElement
    | Large of bool
    | OnChange of string //FormEventHandler //TODO: FromEventHandler is missing from react
    | TagName of obj
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Checkbox =
    let inline checkbox (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Checkbox" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
