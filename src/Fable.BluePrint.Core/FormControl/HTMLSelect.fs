namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module HTMLSelect =

    type IHTMLSelectProps =
        | Disabled of bool
        | ElementRef of (ReactElement -> unit)
        | Fill of bool
        | IconProps of Icon.IIconProps
        | Large of bool
        | OnChange of obj //TODO: write down change event
        | Options of IOptionProps []
        | Value of string

    let inline htmlSelect (props : IHTMLSelectProps list) (elems : ReactElement list) : ReactElement =
        ofImport "HTMLSelect" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
