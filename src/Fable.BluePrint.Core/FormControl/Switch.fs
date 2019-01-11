namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

type ISwitchProps =
    | AlignIndicator of Alignment
    | Checked of bool
    | Children of ReactElement
    | ClassName of string
    | DefaultChecked of bool
    | Disabled of bool
    | Inline of bool
    | InputRef of (ReactElement -> unit)
    | Label of string
    | LabelElement of ReactElement
    | Large of bool
    | OnChange of FormEventHandler
    | TagName of obj
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Switch =
    let inline switch (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "switch" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
