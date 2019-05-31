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
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module NonIdealState =
    let inline nonIdealState (props : INonIdealStateProps list)
               (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "NonIdealState" "@blueprintjs/core" props elems
