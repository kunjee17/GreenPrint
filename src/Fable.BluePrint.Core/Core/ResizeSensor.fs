namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

type IResizeEntry =
    | ContentRect of ReactElement
    | Target of ReactElement
    interface IHTMLProp

type IResizeSensorProps =
    | ObserveParents of bool
    | OnResize of (IResizeEntry [] -> unit)
    interface IHTMLProp

[<RequireQualifiedAccess>]
module ResizeSensor =
    let inline resizeSensor (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "ResizeSensor" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
