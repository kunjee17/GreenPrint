namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module rec PanelStack =
    type IPanelProps<'a> =
        | ClassName of string
    type IPanel<'a> =
        | Component of ReactComponentType<IPanelProps<'a>>
        | Props of 'a
        | Title of ReactNode
    type IPanelStackProps<'a> =
        | ClassName of string
        | InitialPanel of IPanel<'a>
        | OnClose of (IPanel<'a> -> unit)
        | OnOpen of (IPanel<'a> -> unit)

    let inline panelStack (props : IPanelStackProps<_> list) (elems : ReactElement list) : ReactElement =
        ofImport "PanelStack" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
