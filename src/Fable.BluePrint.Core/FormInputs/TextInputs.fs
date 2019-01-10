namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop
open Fable.BluePrint.Icons

type IInputGroupProps =
    | ClassName of string
    | DefaultValue of string
    | Disabled of bool
    | InputRef of (ReactElement -> obj)
    | Intent of Intent
    | Large of bool
    | LeftIcon of IconNames option
    | OnChange of FormEventHandler
    | Placeholder of string
    | RightElement of ReactElement
    | Round of bool
    | Small of bool
    | Type of string
    | Value of string
    interface IHTMLProp

type ITextAreaProps =
    | ClassName of string
    | Fill of bool
    | InputRef of (ReactElement -> obj)
    | Intent of Intent
    | Large of bool
    | Small of bool
    interface IHTMLProp

[<RequireQualifiedAccess>]
module TextInput =
    let inline InputGroup (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "InputGroup" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
    let inline textArea (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "TextArea" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
