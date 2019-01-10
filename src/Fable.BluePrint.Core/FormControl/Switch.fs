namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module Switch =
    type ISwitchProps =
        | AlignIndicator of Alignment
        | Checked of bool
        | Children of ReactNode
        | ClassName of string
        | DefaultChecked of bool
        | Disabled of bool
        | Inline of bool
        | InputRef of (ReactElement -> unit)
        | Label of string
        | LabelElement of ReactNode
        | Large of bool
        | OnChange of FormEventHandler
        | TagName of obj

    let inline switch (props : ISwitchProps list) (elems : ReactElement list) : ReactElement =
        ofImport "switch" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
