namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
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
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Icon =
    let inline icon (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Icon" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
