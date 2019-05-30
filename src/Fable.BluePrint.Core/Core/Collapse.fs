namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props
open Browser.Types

open Fable.Core.JsInterop

type ICollapseProps =
    | ClassName of string
    | Component of ReactElement
    | IsOpen of bool
    | KeepChildrenMounted of bool
    | TransitionDuration of int
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Collapse =
    let inline collapse (props : ICollapseProps list)
               (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "Collapse" "@blueprintjs/core" props elems
