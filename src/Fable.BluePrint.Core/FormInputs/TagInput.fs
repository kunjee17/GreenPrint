namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props
open Browser.Types

open Fable.Core.JsInterop
open Fable.BluePrint.Icons

type ITagInputProps =
    | AddOnBlur of bool
    | AddOnPaste of bool
    | ClassName of string
    | Disabled of bool
    | Fill of bool
    | InputProps of IHTMLProp
    | InputRef of (ReactElement -> unit)
    | InputValue of string
    | Large of bool
    | LeftIcon of IconNames option
    | OnAdd of (string [] -> bool)
    | OnChange of (ReactElement [] -> bool)
    | OnInputChange of string //FormEventHandler //TODO: add missing form event handler
    | OnKeyDown of (KeyboardEvent * int -> unit)
    | OnKeyUp of (KeyboardEvent * int -> unit)
    | OnRemove of (string * int -> unit)
    | Placeholder of string
    | RightElement of ReactElement
    | Separator of string
    | TagProps of ITagProps
    | Values of ReactElement []
    interface IHTMLProp

[<RequireQualifiedAccess>]
module TagInput =
    let inline tagInput (props : IHTMLProp list)
               (elems : ReactElement list) : ReactElement =
        ofImport "TagInput" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
