namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop
open Fable.BluePrint.Icons

[<RequireQualifiedAccess>]
module Menu =

    type IMenuProps =
        | ClassName of string
        | Large of int
        | UlRef of obj

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
        | Text of string


    type IMenuDividerProps =
        | ClassName of string
        | Title of ReactNode


    let inline menu (props : IMenuProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Menu" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems

    let inline menuItem (props : IMenuItemProps list) (elems : ReactElement list) : ReactElement =
        ofImport "MenuItem" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems

    let inline menuDivider (props : IMenuDividerProps list) (elems : ReactElement list) : ReactElement =
        ofImport "MenuDivider" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
