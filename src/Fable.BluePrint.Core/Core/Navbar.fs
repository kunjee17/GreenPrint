namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module Navbar =
    type INavbarProps =
        | ClassName of string
        | FixedToTop of bool

    type INavbarGroupProps =
        | Align of Alignment
        | ClassName of string

    type INavbarHeadingProps = ClassName of string

    type INavbarDividerProps = ClassName of string

    let inline navbar (props : INavbarProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Navbar" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
    let inline navbarGroup (props : INavbarGroupProps list)
               (elems : ReactElement list) : ReactElement =
        ofImport "NavbarGroup" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
    let inline navbarHeading (props : INavbarHeadingProps list)
               (elems : ReactElement list) : ReactElement =
        ofImport "NavbarHeading" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
    let inline navbarDivider (props : INavbarDividerProps list)
               (elems : ReactElement list) : ReactElement =
        ofImport "NavbarDivider" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
