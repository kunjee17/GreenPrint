namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop
open Fable.Blueprint.Icons

[<RequireQualifiedAccess>]
module Callout =

    type ICalloutProps =
        | ClassName of string
        | Icon of IconNames option
        | Intent of Intent
        | Title of string

    let inline callout (props : ICalloutProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Callout" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
