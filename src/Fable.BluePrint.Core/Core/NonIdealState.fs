namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop
open Fable.BluePrint.Icons

[<RequireQualifiedAccess>]
module NonIdealState =

    type INonIdealStateProps =
        | Action of ReactElement
        | Children of ReactElement
        | ClassName of string
        | Description of ReactElement
        | Icon of IconNames option
        | Title of ReactNode

    let inline nonIdealState (props : INonIdealStateProps list) (elems : ReactElement list) : ReactElement =
        ofImport "NonIdealState" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
