namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props
open Browser.Types

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
    | Props of IHTMLProp list
    interface IHTMLProp

type ITabProps =
    | Children of ReactElement
    | ClassName of string
    | Disabled of bool
    | Id of TabId
    | Panel of ReactElement
    | Title of ReactElement
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Tabs =
    let inline tabs (props : ITabsProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | ITabsProps.Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "Tabs" "@blueprintjs/core" props  elems
    let inline tab (props : ITabProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | ITabProps.Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "Tab" "@blueprintjs/core" props elems
