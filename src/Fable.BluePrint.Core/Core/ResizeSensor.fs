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
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module ResizeSensor =
    let inline resizeSensor (props : IResizeSensorProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "ResizeSensor" "@blueprintjs/core" props elems
