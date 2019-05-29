namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module Label =

    let inline label (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Label" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
