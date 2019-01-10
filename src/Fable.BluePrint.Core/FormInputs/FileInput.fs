namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

type IFileInputProps =
    | Disabled of bool
    | Fill of bool
    | InputProps of IHTMLProp
    | Large of bool
    | OnInputChange of FormEventHandler
    | Text of ReactElement
    interface IHTMLProp

[<RequireQualifiedAccess>]
module FileInput =
    let inline fileInput (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "FileInput" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
