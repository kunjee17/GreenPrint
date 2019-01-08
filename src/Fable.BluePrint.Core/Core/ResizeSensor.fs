namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module ResizeSensor =
    type IResizeEntry =
        | ContentRect of ReactDOM
        | Target of ReactElement

    type IResizeSensorProps =
        | ObserveParents of bool
        | OnResize of (IResizeEntry [] -> unit)

    let inline resizeSensor (props : IResizeSensorProps list)
               (elems : ReactElement list) : ReactElement =
        ofImport "ResizeSensor" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
