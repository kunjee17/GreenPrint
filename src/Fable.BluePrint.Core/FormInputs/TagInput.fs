namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop
open Fable.BluePrint.Icons

[<RequireQualifiedAccess>]
module TagInput =

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
        | OnChange of (ReactNode [] -> bool)
        | OnInputChange of FormEventHandler
        | OnKeyDown of (KeyboardEvent * int -> unit)
        | OnKeyUp of (KeyboardEvent * int -> unit)
        | OnRemove of (string * int -> unit)
        | Placeholder of string
        | RightElement of ReactElement
        | Separator of string
        | TagProps of Tag.ITagProps
        | Values of ReactNode []

    let inline tagInput (props : ITagInputProps list) (elems : ReactElement list) : ReactElement =
        ofImport "TagInput" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
