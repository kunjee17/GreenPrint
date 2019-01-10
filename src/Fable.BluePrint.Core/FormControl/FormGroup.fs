namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module FormGroup =

    type IFormGroupProps =
        | ClassName of string
        | ContentClassName of string
        | Disabled of bool
        | HelperText of ReactNode
        | Inline of bool
        | Intent of Intent
        | Label of ReactNode
        | LabelFor of string
        | LabelInfo of ReactNode
        | Style of CSSProp

    let inline formGroup (props : IFormGroupProps list) (elems : ReactElement list) : ReactElement =
        ofImport "FormGroup" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
