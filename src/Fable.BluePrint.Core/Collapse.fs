namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module Collapse =

    type ICollapseProps =
        | ClassName of string
        | Component of ReactType
        | IsOpen of bool
        | KeepChildrenMounted of bool
        | TransitionDuration of int

    let inline collapse (props : ICollapseProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Collapse" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
