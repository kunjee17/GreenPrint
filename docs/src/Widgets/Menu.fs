module Widgets.Menu

open Fable.React
open Fable.React.Props
open Elmish
open Fulma
open Fable.FontAwesome

type CoreModules =
    | Components
    | FormControls
    | FormInputs
    | Overlays

type Library =
    | Core of CoreModules

type Core =
    {
      IsComponentsExpanded : bool
      IsFormControlsExpanded : bool
      IsFormInputsExpanded : bool
      IsOverlaysExpanded : bool }

type Model =
    { Core : Core
      CurrentPage : Router.Page }

type Msg =
    | ToggleMenu of Library

let init currentPage : Model =
    { Core =
            {
              IsComponentsExpanded = false
              IsFormControlsExpanded = false
              IsFormInputsExpanded = false
              IsOverlaysExpanded = false }
      CurrentPage = currentPage }

let update msg model =
    match msg with
    | ToggleMenu library ->
        match library with
        | Core ``module`` ->
            match ``module`` with
            | Components ->
                { model with Core =
                                { model.Core with IsComponentsExpanded = not model.Core.IsComponentsExpanded } }

            | FormControls ->
                { model with Core =
                                { model.Core with IsFormControlsExpanded = not model.Core.IsFormControlsExpanded } }

            | FormInputs ->
                { model with Core =
                                { model.Core with IsFormInputsExpanded = not model.Core.IsFormInputsExpanded}}

            | Overlays ->
                {model with Core =
                                { model.Core with IsOverlaysExpanded = not model.Core.IsOverlaysExpanded}}


        , Cmd.none

open Router

let private menuItem label page currentPage =
    li []
       [ a [ classList [ "is-active", page = currentPage ]
             Router.href page ]
           [ str label ] ]

let private menuFulma currentPage subModel dispatch =

    let (componentsClass, componentsIcon) =
        if not subModel.IsComponentsExpanded then
            match currentPage with
            | Core (Components _) ->
                "menu-group is-active", Fa.Solid.AngleDown
            | _ -> "menu-group", Fa.Solid.AngleDown
        else
            "menu-group", Fa.Solid.AngleUp

    let (formControlClass, formControlIcon) =
        if not subModel.IsFormControlsExpanded then
            match currentPage with
            | Core (FormControls _) ->
                "menu-group is-active", Fa.Solid.AngleDown
            | _ -> "menu-group", Fa.Solid.AngleDown
        else
            "menu-group", Fa.Solid.AngleUp

    let (formInputsClass, formInputsIcon) =
        if not subModel.IsFormInputsExpanded then
            match currentPage with
            | Core (FormInputs _) ->
                "menu-group is-active", Fa.Solid.AngleDown
            | _ -> "menu-group", Fa.Solid.AngleDown
        else
            "menu-group", Fa.Solid.AngleUp

    let (overlaysClass, overlaysIcon) =
        if not subModel.IsOverlaysExpanded then
            match currentPage with
            | Core (Overlays _) ->
                "menu-group is-active", Fa.Solid.AngleDown
            | _ -> "menu-group", Fa.Solid.AngleDown
        else
            "menu-group", Fa.Solid.AngleUp

    [ Menu.label [ ] [ str "Core" ]
      Menu.list [ ]
        [
            menuItem "Introduction" (Core CorePage.Introduction) currentPage
            menuItem "Versions" (Core CorePage.Versions) currentPage
            menuItem "Accessibility" (Core CorePage.Accessibility) currentPage
            menuItem "Classes" (Core CorePage.Classes) currentPage
            menuItem "Colors" (Core CorePage.Colors) currentPage
            menuItem "Typography" (Core CorePage.Typography) currentPage
            menuItem "Variables" (Core CorePage.Variables) currentPage
           ]
      //Menu.list [ ]
      //  [ li [ ]
      //       [ yield a [ ClassName overlaysClass
      //                   OnClick (fun _ -> ToggleMenu (Library.Core Modifiers) |> dispatch ) ]
      //                 [ span [ ]
      //                      [ str "Modifiers" ]
      //                   Icon.icon [ ]
      //                      [ Fa.i [ overlaysIcon ]
      //                          [ ] ] ]
      //         if subModel.IsOverlaysExpanded then
      //              yield ul [ ]
      //                       [ menuItem "Basics" (Core (Modifier Modifiers.Basics)) currentPage
      //                         menuItem "Colors & Shades" (Core (Modifier Modifiers.Colors)) currentPage
      //                         menuItem "Typography" (Core (Modifier Modifiers.Typography)) currentPage
      //                         menuItem "Responsive" (Core (Modifier Modifiers.Responsive)) currentPage ] ] ]
      //Menu.list [ ]
      //  [ li [ ]
      //       [ yield a [ ClassName formInputsClass
      //                   OnClick (fun _ -> ToggleMenu (Library.Core Layouts) |> dispatch ) ]
      //                 [ span [ ] [ str "Layouts" ]
      //                   Icon.icon [ ]
      //                      [ Fa.i [ formControlIcon ]
      //                          [ ] ] ]
      //         if subModel.IsFormControlsExpanded then
      //              yield ul [ ]
      //                       [ menuItem "Columns" (Core (Layout Layouts.Columns)) currentPage
      //                         menuItem "Container" (Core (Layout Layouts.Container)) currentPage
      //                         menuItem "Footer" (Core (Layout Layouts.Footer)) currentPage
      //                         menuItem "Hero" (Core (Layout Layouts.Hero)) currentPage
      //                         menuItem "Level" (Core (Layout Layouts.Level)) currentPage
      //                         menuItem "Section" (Core (Layout Layouts.Section)) currentPage
      //                         menuItem "Tile" (Core (Layout Layouts.Tile)) currentPage ] ] ]
      //Menu.list [ ]
        //[ li [ ]
             //[ yield a [ ClassName elementsClass
               //          OnClick (fun _ -> ToggleMenu (Library.Core Elements) |> dispatch ) ]
               //        [ span [ ] [ str "Elements" ]
               //          Icon.icon [ ]
               //             [ Fa.i [ elementsIcon ]
               //                 [ ] ] ]
               //if subModel.IsElementsExpanded then
                    //yield ul [ ]
                             //[ menuItem "Box" (Core (Element Elements.Box)) currentPage
                               //menuItem "Button" (Core (Element Elements.Button)) currentPage
                               //menuItem "Content" (Core (Element Elements.Content))  currentPage
                               //menuItem "Delete" (Core (Element Elements.Delete)) currentPage
                               //menuItem "Form" (Core (Element Elements.Form)) currentPage
                               //menuItem "Icon" (Core (Element Elements.Icon)) currentPage
                               //menuItem "Image" (Core (Element Elements.Image)) currentPage
                               //menuItem "Notification" (Core (Element Elements.Notification)) currentPage
                               //menuItem "Progress" (Core (Element Elements.Progress))  currentPage
                               //menuItem "Table" (Core (Element Elements.Table)) currentPage
                               //menuItem "Tag" (Core (Element Elements.Tag)) currentPage
                               //menuItem "Title" (Core (Element Elements.Title)) currentPage ] ] ]
      Menu.list [ ]
        [ li [ ]
             [ yield a [ ClassName componentsClass
                         OnClick (fun _ -> ToggleMenu (Library.Core CoreModules.Components  ) |> dispatch ) ]
                       [ span [ ] [ str "Components" ]
                         Icon.icon [ ]
                            [ Fa.i [ componentsIcon ]
                                [ ] ] ]
               if subModel.IsComponentsExpanded then
                    yield ul [ ]
                             [
                                menuItem "Breadcrumbs" (Core (Components Components.Breadcrumbs)) currentPage
                                menuItem "Button" (Core (Components Components.Button)) currentPage
                                menuItem "ButtonGroup" (Core (Components Components.ButtonGroup)) currentPage
                                menuItem "Callout" (Core (Components Components.Callout)) currentPage
                                menuItem "Card" (Core (Components Components.Card)) currentPage
                                menuItem "Collapse" (Core (Components Components.Collapse)) currentPage

                               ] ] ] ]




let view model dispatch =
    Menu.menu [ ]
        [ yield Menu.list [ ]
                   [ menuItem "Introduction" Home model.CurrentPage
                    ]
          yield! menuFulma model.CurrentPage model.Core dispatch
          ]
