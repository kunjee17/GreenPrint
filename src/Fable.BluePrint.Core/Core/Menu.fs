namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props
open Browser.Types

open Fable.Core.JsInterop
open Fable.BluePrint.Icons

type IMenuProps =
    | ClassName of string
    | Large of int
    | UlRef of obj
    interface IHTMLProp

type IMenuItemProps =
    | Active of bool
    | Children of ReactElement
    | ClassName of string
    | Disabled of bool
    | Href of string
    | Icon of IconNames option
    | Intent of Intent
    | Label of string
    | LabelElement of ReactElement
    | Multiline of bool
    | OnClick of (MouseEvent -> unit)
    | PopoverProps of obj //TODO: IPopoverProps will come
    | ShouldDismissPopover of bool
    | TagName of obj
    | Target of string
    | Text of ReactElement
    interface IHTMLProp

type IMenuDividerProps =
    | ClassName of string
    | Title of ReactElement
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Menu =
    let inline menu (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Menu" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
    let inline menuItem (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "MenuItem" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
    let inline menuDivider (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "MenuDivider" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
