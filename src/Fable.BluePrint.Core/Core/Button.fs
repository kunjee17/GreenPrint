namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props
open Browser.Types

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
    | Text of ReactElement
    | Type of ButtonType
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Button =
    let inline button (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Button" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
    let inline anchorButton (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "AnchorButton" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
