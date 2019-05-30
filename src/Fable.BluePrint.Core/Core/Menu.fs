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
    | Props of IHTMLProp list
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
    | Props of IHTMLProp list
    interface IHTMLProp

type IMenuDividerProps =
    | ClassName of string
    | Title of ReactElement
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Menu =
    let inline menu (props : IMenuProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | IMenuProps.Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "Menu" "@blueprintjs/core" props elems
    let inline menuItem (props : IMenuItemProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | IMenuItemProps.Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "MenuItem" "@blueprintjs/core" props elems
    let inline menuDivider (props : IMenuDividerProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | IMenuDividerProps.Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "MenuDivider" "@blueprintjs/core" props elems
