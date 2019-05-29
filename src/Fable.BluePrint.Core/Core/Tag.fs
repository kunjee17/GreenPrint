namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props
open Browser.Types

open Fable.Core.JsInterop
open Fable.BluePrint.Icons

type ITagProps =
    | Active of bool
    | ClassName of string
    | Icon of IconNames option
    | Intent of Intent
    | Interactive of bool
    | Large of bool
    | Minimal of bool
    | Multiline of bool
    | OnClick of (MouseEvent -> unit)
    | OnRemove of (MouseEvent * ITagProps -> unit)
    | RightIcon of IconNames option
    | Round of bool
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Tag =
    let inline tag (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Tag" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
