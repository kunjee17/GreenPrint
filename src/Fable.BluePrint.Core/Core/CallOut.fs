namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop
open Fable.BluePrint.Icons

type ICalloutProps =
    | ClassName of string
    | Icon of IconNames option
    | Intent of Intent
    | Title of string
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Callout =
    let inline callout (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Callout" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
