namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module Checkbox =

    type ICheckboxProps =
        | AlignIndicator of Alignment
        | Checked of bool
        | Children of ReactNode
        | ClassName of string
        | DefaultChecked of bool
        | DefaultIndeterminate of bool
        | Disabled of bool
        | Indeterminate of bool
        | Inline of bool
        | InputRef of (ReactElement -> obj)
        | Label of string
        | LabelElement of ReactNode
        | Large of bool
        | OnChange of FormEventHandler
        | TagName of obj

    let inline checkbox (props : ICheckboxProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Checkbox" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
