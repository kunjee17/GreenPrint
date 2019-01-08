namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module OverflowList =

    type IOverflowListProps<'a> =
        | ClassName of string
        | CollapseFrom of Boundary
        | Items of 'a []
        | MinVisibleItems of int
        | ObserveParents of bool
        | OnOverflow of ('a[] -> unit)
        | OverflowRenderer of ('a[] -> ReactElement)
        | Style of CSSProp
        | TagName of obj
        | VisibleItemRenderer of ('a * int -> ReactElement)


    let inline overflowList (props : IOverflowListProps<_> list) (elems : ReactElement list) : ReactElement =
        ofImport "OverflowList" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
