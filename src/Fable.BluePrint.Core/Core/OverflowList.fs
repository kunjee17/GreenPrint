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
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module OverflowList =
    let inline overflowList (props : IOverflowListProps<'a> list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "OverflowList" "@blueprintjs/core" props elems
