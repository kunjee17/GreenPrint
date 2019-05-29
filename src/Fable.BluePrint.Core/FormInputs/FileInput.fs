namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

type IFileInputProps =
    | Disabled of bool
    | Fill of bool
    | InputProps of IHTMLProp
    | Large of bool
    | OnInputChange of string //FormEventHandler //TODO: add missing form event handler
    | Text of ReactElement
    interface IHTMLProp

[<RequireQualifiedAccess>]
module FileInput =
    let inline fileInput (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "FileInput" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
