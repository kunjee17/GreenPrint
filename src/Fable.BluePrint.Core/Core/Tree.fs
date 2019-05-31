namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop
open Fable.BluePrint.Icons
open Browser.Types

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
    interface IHTMLProp // TODO Why don't used

type TreeEventHandler<'a> = ITreeNode<'a> * int [] * MouseEvent -> unit

type ITreeProps<'a> =
    | ClassName of string
    | Contents of ITreeNode<'a>
    | OnNodeClick of TreeEventHandler<'a>
    | OnNodeCollapse of TreeEventHandler<'a>
    | OnNodeContextMenu of TreeEventHandler<'a>
    | OnNodeDoubleClick of TreeEventHandler<'a>
    | OnNodeExpand of TreeEventHandler<'a>
    | Props of IHTMLProp list
    interface IHTMLProp

[<RequireQualifiedAccess>]
module Tree =
    let inline tree (props : ITreeProps<'a> list) (elems : ReactElement list) : ReactElement =
        let props = OptionsStore.Parse(props, fun rslt opt -> match opt with | ITreeProps.Props p -> rslt.AddProps p | p -> rslt.AddProp p ).ToLowerFirstObj()
        ofImport "Tree" "@blueprintjs/core" props elems
