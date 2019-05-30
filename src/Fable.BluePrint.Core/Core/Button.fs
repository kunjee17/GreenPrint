namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props
open Browser.Types

open Fable.Core.JsInterop
open Fable.BluePrint.Icons
open OptionsStore

[<StringEnum>]
type ButtonType =
    | Button
    | Submit

// type Props = Props of

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
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Button =
    let fldr = fun (r:OptionsStore) el -> match el with | Props p -> r.AddProps p | x -> r.AddProp x
    let inline button (props : IButtonProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fldr).ToLowerFirstObj()
        ofImport "Button" "@blueprintjs/core" props elems
    let inline anchorButton (props : IButtonProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fldr).ToLowerFirstObj()
        ofImport "AnchorButton" "@blueprintjs/core" props elems
