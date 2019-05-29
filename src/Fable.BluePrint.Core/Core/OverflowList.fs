namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

type IOverflowListProps<'a> =
    | ClassName of string
    | CollapseFrom of Boundary
    | Items of 'a []
    | MinVisibleItems of int
    | ObserveParents of bool
    | OnOverflow of ('a [] -> unit)
    | OverflowRenderer of ('a [] -> ReactElement)
    | Style of CSSProp
    | TagName of obj
    | VisibleItemRenderer of ('a * int -> ReactElement)
    interface IHTMLProp

[<RequireQualifiedAccess>]
module OverflowList =
    let inline overflowList (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "OverflowList" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
