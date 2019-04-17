namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

type IDividerProps =
    | ClassName of string
    | TagName of obj
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Divider =
    let inline divider (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Divider" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
