namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

type INavbarProps =
    | ClassName of string
    | FixedToTop of bool
    interface IHTMLProp

type INavbarGroupProps =
    | Align of Alignment
    | ClassName of string
    interface IHTMLProp

type INavbarHeadingProps =
    | ClassName of string
    interface IHTMLProp

type INavbarDividerProps =
    | ClassName of string
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Navbar =
    let inline navbar (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Navbar" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
    let inline navbarGroup (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "NavbarGroup" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
    let inline navbarHeading (props : IHTMLProp list)
               (elems : ReactElement list) : ReactElement =
        ofImport "NavbarHeading" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
    let inline navbarDivider (props : IHTMLProp list)
               (elems : ReactElement list) : ReactElement =
        ofImport "NavbarDivider" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
