namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop
open Fable.BluePrint.Icons

type INonIdealStateProps =
    | Action of ReactElement
    | Children of ReactElement
    | ClassName of string
    | Description of ReactElement
    | Icon of IconNames option
    | Title of ReactElement
    interface IHTMLProp

[<RequireQualifiedAccess>]
module NonIdealState =
    let inline nonIdealState (props : IHTMLProp list)
               (elems : ReactElement list) : ReactElement =
        ofImport "NonIdealState" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
