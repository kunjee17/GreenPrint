namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module HtmlElements =
    let inline h1 (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "H1" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems

    let inline h2 (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "H2" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems

    let inline h3 (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "H3" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems

    let inline h4 (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "H4" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems

    let inline h5 (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "H5" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems

    let inline h6 (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "H6" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems

    let inline blockquote (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Blockquote" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems

    let inline code (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Code" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems

    let inline label (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Label" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems

    let inline pre (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Pre" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems

    let inline ol (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "OL" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems

    let inline ul (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "UL" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems

    let inline HtmlTable  (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "HTMLTable" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
