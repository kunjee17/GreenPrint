namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props
open Browser.Types

open Fable.Core.JsInterop

type IPanelProps<'a> =
    | ClassName of string
    // | Props of IHTMLProp list
    interface IHTMLProp

type IPanel<'a> =
    | Component of ReactElementType<IPanelProps<'a>>
    | Props of 'a // What is this?
    | Title of ReactElement
    interface IHTMLProp

type IPanelStackProps<'a> =
    | ClassName of string
    | InitialPanel of IPanel<'a>
    | OnClose of (IPanel<'a> -> unit)
    | OnOpen of (IPanel<'a> -> unit)
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module rec PanelStack =
    let inline panelStack (props : IPanelStackProps<'a> list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "PanelStack" "@blueprintjs/core" props elems
