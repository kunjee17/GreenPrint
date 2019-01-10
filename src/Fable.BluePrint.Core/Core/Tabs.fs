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
    interface IHTMLProp

type ITabProps =
    | Children of ReactElement
    | ClassName of string
    | Disabled of bool
    | Id of TabId
    | Panel of ReactElement
    | Title of ReactElement
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Tabs =
    let inline tabs (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Tabs" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
    let inline tab (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Tab" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
