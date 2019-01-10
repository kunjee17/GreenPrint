namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module FileInput =

    type IFileInputProps =
        | Disabled of bool
        | Fill of bool
        | InputProps of IHTMLProp
        | Large of bool
        | OnInputChange of FormEventHandler
        | Text of ReactNode

    let inline fileInput (props : IFileInputProps list) (elems : ReactElement list) : ReactElement =
        ofImport "FileInput" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
