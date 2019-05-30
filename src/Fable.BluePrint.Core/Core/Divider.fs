namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

type IDividerProps =
    | ClassName of string
    | TagName of obj
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Divider =
    let inline divider (props : IDividerProps list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "Divider" "@blueprintjs/core" props elems
