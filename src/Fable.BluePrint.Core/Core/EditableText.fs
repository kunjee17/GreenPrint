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
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module EditableText =
    let inline editableText (props : IEditableTextProps list)
               (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "EditableText" "@blueprintjs/core" props elems
