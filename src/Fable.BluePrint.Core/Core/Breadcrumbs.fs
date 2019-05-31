namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props
open Browser.Types

open Fable.Core.JsInterop
open Fable.BluePrint.Icons
open OptionsStore
open Fable.React.ReactiveComponents

type IBreadcrumbProps =
    | ClassName of string
    | Current of bool
    | Disabled of bool
    | Href of string
    | Icon of IconNames option
    | Itent of Intent
    | OnClick of (MouseEvent -> unit)
    | Target of string
    | Text of ReactElement
    | Props of IHTMLProp list
    interface IHTMLProp

type IBreadcrumbsProps =
    | BreadcrumbRenderer of (IBreadcrumbProps list -> ReactElement list -> ReactElement)
    | ClassName of string
    | CollapseFrom of Boundary
    | CurrentBreadcrumbRenderer of (IBreadcrumbProps list -> ReactElement list -> ReactElement)
    | Items of IBreadcrumbProps list
    | MinVisibleItems of int
    | OverflowListProps of obj //TODO: Overflow props comes here
    | PopoverProps of obj //TODO: IPopoverProps comes here
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Breadcrumbs =
    let inline breadcrumb (props : IBreadcrumbProps list)
               (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | IBreadcrumbProps.Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "Breadcrumb" "@blueprintjs/core" props elems
    let inline breadcrumbs (props : IBreadcrumbsProps list)
               (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "Breadcrumbs" "@blueprintjs/core" props elems
