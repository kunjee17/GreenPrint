namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

type IResizeEntry =
    | ContentRect of ReactDOM
    | Target of ReactElement

type IResizeSensorProps =
    | ObserveParents of bool
    | OnResize of (IResizeEntry [] -> unit)

[<RequireQualifiedAccess>]
module ResizeSensor =
    let inline resizeSensor (props : IResizeSensorProps list)
               (elems : ReactElement list) : ReactElement =
        ofImport "ResizeSensor" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
