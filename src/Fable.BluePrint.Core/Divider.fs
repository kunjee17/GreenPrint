namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module Divider =

    type IDividerProps =
        | ClassName of string
        | TagName of obj

    let inline divider (props : IDividerProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Divider" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
