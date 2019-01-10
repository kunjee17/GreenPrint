namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop
open Fable.Blueprint.Icons

[<RequireQualifiedAccess>]
module NumericInput =

    type INumericInputProps =
        | AllowNumericCharactersOnly of bool
        | ButtonPosition of BluePrintPosition
        | ClampValueOnBlur of bool
        | ClassName of string
        | Disabled of bool
        | Fill of bool
        | InputRef of (ReactElement -> unit)
        | Intent of Intent
        | Large of bool
        | LeftIcon of IconNames option
        | MajorStepSize of int option
        | Max of float
        | Min of float
        | MinorStepSize of float option
        | OnButtonClick of (float * string -> unit)
        | OnValueChange of (float * string -> unit)
        | Placeholder of string
        | SelectAllOnFocus of bool
        | SelectAllOnIncrement of bool
        | StepSize of int
        | Value of string


    let inline numericInput (props : INumericInputProps list) (elems : ReactElement list) : ReactElement =
        ofImport "NumericInput" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
