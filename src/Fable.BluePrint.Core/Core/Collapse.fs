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
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Collapse =
    let inline collapse (props : IHTMLProp list)
               (elems : ReactElement list) : ReactElement =
        ofImport "Collapse" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
