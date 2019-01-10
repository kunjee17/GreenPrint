namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

type IHTMLSelectProps =
    | Disabled of bool
    | ElementRef of (ReactElement -> unit)
    | Fill of bool
    | IconProps of IIconProps
    | Large of bool
    | OnChange of obj //TODO: write down change event
    | Options of IOptionProps []
    | Value of string
    interface IHTMLProp

[<RequireQualifiedAccess>]
module HTMLSelect =
    let inline htmlSelect (props : IHTMLProp list)
               (elems : ReactElement list) : ReactElement =
        ofImport "HTMLSelect" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
