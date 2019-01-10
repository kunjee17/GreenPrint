namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module Slider =
    type ISliderProps =
        | ClassName of string
        | Disabled of bool
        | InitialValue of int
        | LabelPrecision of int
        | LabelRenderer of bool
        | LabelStepSize of int
        | Max of int
        | Min of int
        | OnChange of (int -> unit)
        | OnRelease of (int -> unit)
        | ShowTrackFill of bool
        | StepSize of int
        | Value of int
        | Vertical of bool

    let inline slider (props : ISliderProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Slider" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems

[<RequireQualifiedAccess>]
module RangeSlider =
    type IRangeSliderProps =
        | ClassName of string
        | Disabled of bool
        | LabelPrecision of int
        | LabelRenderer of bool
        | LabelStepSize of int
        | Max of int
        | Min of int
        | OnChange of (NumberRange -> unit)
        | OnRelease of (NumberRange -> unit)
        | ShowTrackFill of bool
        | StepSize of int
        | Value of NumberRange
        | Vertical of bool

    let inline rangeSlider (props : IRangeSliderProps list)
               (elems : ReactElement list) : ReactElement =
        ofImport "RangeSlider" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems

[<RequireQualifiedAccess>]
module MultiSlider =
    type IMultiSliderProps =
        | ClassName of string
        | DefaultTrackIntent of Intent
        | Disabled of bool
        | LabelPrecision of int
        | LabelRenderer of bool
        | LabelStepSize of int
        | Max of int
        | Min of int
        | OnChange of (NumberRange -> unit)
        | OnRelease of (NumberRange -> unit)
        | ShowTrackFill of bool
        | StepSize of int
        | Vertical of bool

    type IHandleProps =
        | ClassName of string
        | IntentAfter of Intent
        | IntentBefore of Intent
        | InteractionKind of HandleInteractionKind
        | OnChange of (int -> unit)
        | OnRelease of (int -> unit)
        | Type of HandleType
        | Value of int

    let inline multiSlider (props : IMultiSliderProps list)
               (elems : ReactElement list) : ReactElement =
        ofImport "MultiSlider" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
    let inline multiSliderHandle (props : IHandleProps list)
               (elems : ReactElement list) : ReactElement =
        ofImport "MultiSlider.Handle" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
