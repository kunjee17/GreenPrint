namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop
open Fable.BluePrint.Icons

[<StringEnum>]
type ButtonType =
    | Button
    | Submit

type IButtonProps =
    | Active of bool
    | AlignText of AlignText
    | ClassName of string
    | Disabled of bool
    | Fill of bool
    | Icon of IconNames option
    | Intent of Intent
    | Large of bool
    | Loading of bool
    | Minimal of bool
    | OnClick of (MouseEvent -> unit)
    | RightIcon of string //IconName will come
    | Text of string
    | Type of ButtonType

[<RequireQualifiedAccess>]
module Button =
    let inline button (props : IButtonProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Button" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
    let inline anchorButton (props : IButtonProps list)
               (elems : ReactElement list) : ReactElement =
        ofImport "AnchorButton" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
