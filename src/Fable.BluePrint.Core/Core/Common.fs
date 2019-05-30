namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop


[<StringEnum>]
type Alignment =
    | CENTER
    | LEFT
    | RIGHT

[<StringEnum>]
type AlignText =
    | CENTER
    | LEFT
    | RIGHT

[<StringEnum>]
type Intent =
    | DANGER
    | NONE
    | PRIMARY
    | SUCCESS
    | WARNING

[<StringEnum>]
type Boundary =
    | END
    | START

type IOptionProps =
    | ClassName of string
    | Disabled of bool
    | Label of string
    | Value of string

type Elevation =
    | ZERO = 0
    | ONE = 1
    | TWO = 2
    | THREE = 3
    | FOUR = 4

[<StringEnum>]
type HandleInteractionKind =
    | LOCK
    | NONE
    | PUSH

[<StringEnum>]
type HandleType =
    | FULL
    | END
    | START

[<StringEnum>]
type BluePrintPosition =
    | LEFT
    | RIGHT
    | NONE

type NumberRange = int []

module OptionsStore =
  type OptionsStore =
   { Props : IHTMLProp list} with
   member this.AddProp prop =
     { this with Props = prop::this.Props }
   member this.AddProps props =
     { this with Props = props@this.Props }
   member this.ToKeyValListObj (caseRules: CaseRules ) =
     keyValueList caseRules this.Props
   member this.ToLowerFirstObj() =
     this.ToKeyValListObj (CaseRules.LowerFirst)
   member this.UseToImportWithCase(importMember, importPath, caseRules, ?children) =
     let children = defaultArg children []
     let prop = this.ToKeyValListObj(caseRules)
     ofImport importMember importPath prop children
   member this.UseToImportWithLowerCase(importMember, importPath, ?children) =
     this.UseToImportWithCase(importMember,importPath, CaseRules.LowerFirst, defaultArg children [])
   member this.UseToImportWithNoneCase(importMember, importPath, ?children) =
     this.UseToImportWithCase(importMember,importPath, CaseRules.None, defaultArg children [])



  let Empty = { Props = [] }

  let Parse (props, folder) = props |> List.fold folder Empty