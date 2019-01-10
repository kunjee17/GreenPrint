namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop
open Fable.BluePrint.Icons

type NodeId = int //number of string where I choose number

type ITreeNode<'a> =
    | ChildNodes of ITreeNode<'a>
    | ClassName of string
    | HasCaret of bool
    | Icon of IconNames option
    | Id of NodeId
    | IsExpanded of bool
    | IsSelected of bool
    | Label of ReactElement
    | NodeData of 'a
    | SecondaryLabel of string option

type ITreeNodeProps<'a> =
    | ChildNodes of ITreeNode<'a>
    | Children of ReactElement
    | ClassName of string
    | ContentRef of (ITreeNode<'a> * ReactElement -> unit)
    | Depth of int
    | HasCaret of bool
    | Icon of IconNames option
    | Id of NodeId
    | IsExpanded of bool
    | IsSelected of bool
    | Key of NodeId
    | Label of ReactElement
    | NodeData of 'a
    | OnClick of (ITreeNode<'a> * MouseEvent -> unit)
    | OnCollapse of (ITreeNode<'a> * MouseEvent -> unit)
    | OnContextMenu of (ITreeNode<'a> * MouseEvent -> unit)
    | OnDoubleClick of (ITreeNode<'a> * MouseEvent -> unit)
    | OnExpand of (ITreeNode<'a> * MouseEvent -> unit)
    | Path of int []
    | SecondaryLabel of string option
    interface IHTMLProp

type TreeEventHandler<'a> = ITreeNode<'a> * int [] * MouseEvent -> unit

type ITreeProps<'a> =
    | ClassName of string
    | Contents of ITreeNode<'a>
    | OnNodeClick of TreeEventHandler<'a>
    | OnNodeCollapse of TreeEventHandler<'a>
    | OnNodeContextMenu of TreeEventHandler<'a>
    | OnNodeDoubleClick of TreeEventHandler<'a>
    | OnNodeExpand of TreeEventHandler<'a>
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Tree =
    let inline tree (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Tree" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
