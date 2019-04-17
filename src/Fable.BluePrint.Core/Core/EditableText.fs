namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

type IEditableTextProps =
    | ClassName of string
    | ConfirmOnEnterKey of bool
    | DefaultValue of string
    | Disabled of bool
    | Intent of Intent
    | IsEditing of bool
    | MaxLength of int
    | MaxLines of int
    | MinLines of int
    | MinWidth of int
    | Multiline of bool
    | OnCancel of (string -> unit)
    | OnChange of (string -> unit)
    | OnConfirm of (string -> unit)
    | OnEdit of (string -> unit)
    | Placeholder of string
    | SelectAllOnFocus of bool
    | Value of string
    interface IHTMLProp

[<RequireQualifiedAccess>]
module EditableText =
    let inline editableText (props : IHTMLProp list)
               (elems : ReactElement list) : ReactElement =
        ofImport "EditableText" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
