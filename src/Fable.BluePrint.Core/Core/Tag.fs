namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
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

[<RequireQualifiedAccess>]
module Tag =
    let inline tag (props : ITagProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Tag" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
