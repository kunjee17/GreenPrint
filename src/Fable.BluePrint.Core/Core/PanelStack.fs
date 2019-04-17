namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props
open Browser.Types

open Fable.Core.JsInterop

type IPanelProps<'a> =
    | ClassName of string
    interface IHTMLProp

type IPanel<'a> =
    | Component of ReactElementType<IPanelProps<'a>>
    | Props of 'a
    | Title of ReactElement
    interface IHTMLProp

type IPanelStackProps<'a> =
    | ClassName of string
    | InitialPanel of IPanel<'a>
    | OnClose of (IPanel<'a> -> unit)
    | OnOpen of (IPanel<'a> -> unit)
    interface IHTMLProp

[<RequireQualifiedAccess>]
module rec PanelStack =
    let inline panelStack (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "PanelStack" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
