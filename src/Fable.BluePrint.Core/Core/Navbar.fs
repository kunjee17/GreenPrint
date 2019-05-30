namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

type INavbarProps =
    | ClassName of string
    | FixedToTop of bool
    | Props of IHTMLProp list
    interface IHTMLProp

type INavbarGroupProps =
    | Align of Alignment
    | ClassName of string
    | Props of IHTMLProp list
    interface IHTMLProp

type INavbarHeadingProps =
    | ClassName of string
    | Props of IHTMLProp list
    interface IHTMLProp

type INavbarDividerProps =
    | ClassName of string
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Navbar =
    let inline navbar (props : INavbarProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | INavbarProps.Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "Navbar" "@blueprintjs/core" props elems
    let inline navbarGroup (props : INavbarGroupProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | INavbarGroupProps.Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "NavbarGroup" "@blueprintjs/core" props elems
    let inline navbarHeading (props : INavbarHeadingProps list)
               (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | INavbarHeadingProps.Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "NavbarHeading" "@blueprintjs/core" props elems
    let inline navbarDivider (props : INavbarDividerProps list)
               (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | INavbarDividerProps.Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "NavbarDivider" "@blueprintjs/core" props elems
