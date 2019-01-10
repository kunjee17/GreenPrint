namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

type TabId = int

type ITabsProps =
    | Animate of bool
    | ClassName of string
    | DefaultSelectedTabId of TabId //TODO: string or number - I have chose int for simplicity
    | Id of TabId //TODO: same as above
    | Large of bool
    | OnChange of (int * int * MouseEvent -> unit)
    | RenderActiveTabPanelOnly of bool
    | SelectedTabId of TabId //TODO: as above
    | Vertical of bool

type ITabProps =
    | Children of ReactNode
    | ClassName of string
    | Disabled of bool
    | Id of TabId
    | Panel of ReactElement
    | Title of ReactNode

[<RequireQualifiedAccess>]
module Tabs =
    let inline tabs (props : ITabsProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Tabs" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
    let inline tab (props : ITabProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Tab" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
