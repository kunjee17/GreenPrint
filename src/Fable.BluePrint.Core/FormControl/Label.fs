namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module Label =

    let inline label (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Label" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
