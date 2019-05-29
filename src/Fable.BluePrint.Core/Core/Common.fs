namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

[<StringEnum>]
type Alignment =
    | CENTER
    | LEFT
    | RIGHT

[<StringEnum>]
type AlignText =
    | CENTER
    | LEFT
    | RIGHT

[<StringEnum>]
type Intent =
    | DANGER
    | NONE
    | PRIMARY
    | SUCCESS
    | WARNING

[<StringEnum>]
type Boundary =
    | END
    | START

type IOptionProps =
    | ClassName of string
    | Disabled of bool
    | Label of string
    | Value of string

type Elevation =
    | ZERO = 0
    | ONE = 1
    | TWO = 2
    | THREE = 3
    | FOUR = 4

[<StringEnum>]
type HandleInteractionKind =
    | LOCK
    | NONE
    | PUSH

[<StringEnum>]
type HandleType =
    | FULL
    | END
    | START

[<StringEnum>]
type BluePrintPosition =
    | LEFT
    | RIGHT
    | NONE

type NumberRange = int []
