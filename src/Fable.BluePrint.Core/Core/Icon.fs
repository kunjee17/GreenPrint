namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop
open Fable.BluePrint.Icons

type IIconProps =
    | ClassName of string
    | Color of string
    | Icon of IconNames
    | IconSize of int
    | Intent of Intent
    | Style of CSSProp
    | TagName of obj
    | Title of string option
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Icon =
    let inline icon (props : IIconProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "Icon" "@blueprintjs/core" props elems
