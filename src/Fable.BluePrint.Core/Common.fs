namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
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

type NumberRange = int []
