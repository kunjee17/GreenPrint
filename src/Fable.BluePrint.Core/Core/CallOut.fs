namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop
open Fable.BluePrint.Icons

type ICalloutProps =
    | ClassName of string
    | Icon of IconNames option
    | Intent of Intent
    | Title of string
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Callout =
    let inline callout (props : ICalloutProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "Callout" "@blueprintjs/core" props elems
