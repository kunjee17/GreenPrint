module Router

open Elmish.Navigation
open Elmish.UrlParser
open Fable.React.Props

type Components =
    | Breadcrumbs
    | Button
    | ButtonGroup
    | Callout
    | Card
    | Collapse
    | CollapsibleList
    | Divider
    | EditableText
    | HtmlElement
    | HtmlTable
    | Hotkeys
    | Icon
    | Menu
    | Navbar
    | NonIdealState
    | OverflowList
    | PanelStack
    | ProgressBar
    | ResizeSensor
    | Skeleton
    | Spinner
    | Tabs
    | Tag
    | Text
    | Tree

type FormControls =
    | FormGroup
    | ControlGroup
    | Label
    | Checkbox
    | Radio
    | HTMLSelect
    | Slider
    | Switch

type FormInputs =
    | FileInput
    | NumericInput
    | TextInputs
    | TagInput

 type Overlays =
    | Overlay
    | Portal
    | Alert
    | ContextMenu
    | Dialog
    | Drawer
    | Popover
    | Toast
    | Tooltip



type CorePage =
    | Components of Components
    | FormControls of FormControls
    | FormInputs of FormInputs
    | Overlays of Overlays
    | Introduction
    | Versions
    | Accessibility
    | Classes
    | Colors
    | Typography
    | Variables



type Page =
    | Home
    | Core of CorePage


let private toHash page =
    match page with
    | Home -> "#home"
    | Core pageType ->
        match pageType with
        | CorePage.Introduction -> "#core"
        | Versions -> "#core/versions"
        | Accessibility -> "#core/accessiblity"
        | Classes -> "#core/classes"
        | Colors -> "#core/colors"
        | Typography -> "#core/typography"
        | Variables -> "#core/variables"
        | Components ``component`` ->
            match ``component`` with
            | Breadcrumbs -> "#core/components/breadcrumbs"
            | Button -> "#core/components/button"
            | ButtonGroup -> "#core/components/button-group"
            | Callout -> "#core/components/callout"
            | Card -> "#core/components/card"
            | Collapse -> "#core/components/collapse"
            | CollapsibleList -> "#core/components/collapsible-list"
            | Divider -> "#core/components/divider"
            | EditableText -> "#core/components/editable-text"
            | HtmlElement-> "#core/components/html-element"
            | HtmlTable-> "#core/components/html-table"
            | Hotkeys-> "#core/components/hot-keys"
            | Icon-> "#core/components/icon"
            | Menu-> "#core/components/menu"
            | Navbar-> "#core/components/navbar"
            | NonIdealState-> "#core/components/non-ideal-state"
            | OverflowList-> "#core/components/overflow-list"
            | PanelStack-> "#core/components/panel-stack"
            | ProgressBar-> "#core/components/progress-bar"
            | ResizeSensor-> "#core/components/resize-sensor"
            | Skeleton-> "#core/components/skeleton"
            | Spinner-> "#core/components/spinner"
            | Tabs-> "#core/components/tabs"
            | Tag-> "#core/components/tag"
            | Text-> "#core/components/text"
            | Tree-> "#core/components/tree"
        | FormControls fc ->
            match fc with
            | FormGroup -> "#core/form-controls/form-group"
            | ControlGroup -> "#core/form-controls/control-group"
            | Label -> "#core/form-controls/label"
            | Checkbox-> "#core/form-controls/checkbox"
            | Radio -> "#core/form-controls/radio"
            | HTMLSelect -> "#core/form-controls/html-select"
            | Slider -> "#core/form-controls/slider"
            | Switch -> "#core/form-controls/switch"
        | FormInputs fi ->
            match fi with
            | FileInput -> "#core/form-inputs/file-input"
            | NumericInput-> "#core/form-inputs/numeric-input"
            | TextInputs -> "#core/form-inputs/text-inputs"
            | TagInput -> "#core/form-inputs/tag-input"
        | Overlays o ->
            match o with
            | Overlay -> "#core/overlays/overlay"
            | Portal-> "#core/overlays/portal"
            | Alert-> "#core/overlays/alert"
            | ContextMenu-> "#core/overlays/context-menu"
            | Dialog-> "#core/overlays/dialog"
            | Drawer-> "#core/overlays/drawer"
            | Popover-> "#core/overlays/pop-over"
            | Toast-> "#core/overlays/toast"
            | Tooltip-> "#core/overlays/tooltip"


let pageParser : Parser<Page -> Page, Page> =
    oneOf [ map Home (s "home")
            map (Core CorePage.Introduction ) (s "core")
            map (Core CorePage.Versions ) (s "core" </> s "versions")
            map (Core CorePage.Accessibility ) (s "core" </> s "accessiblity")
            map (Core CorePage.Classes ) (s "core" </> s "classes")
            map (Core CorePage.Colors ) (s "core" </> s "colors")
            map (Core CorePage.Typography ) (s "core" </> s "typography")
            map (Core CorePage.Variables ) (s "core" </> s "variables")

            // Components
            map (Core (Components Breadcrumbs)) (s "core" </> s "components" </> s "breadcrumbs")
            map (Core (Components Button)) (s "core" </> s "components" </> s "button")
            map (Core (Components ButtonGroup)) (s "core" </> s "components" </> s "button-group")
            map (Core (Components Callout)) (s "core" </> s "components" </> s "callout")
            map (Core (Components Card)) (s "core" </> s "components" </> s "card")
            map (Core (Components Collapse)) (s "core" </> s "components" </> s "collapse")
            map (Core (Components CollapsibleList)) (s "core" </> s "components" </> s "collapsible-list")
            map (Core (Components Divider)) (s "core" </> s "components" </> s "divider")
            map (Core (Components EditableText)) (s "core" </> s "components" </> s "editable-text")
            map (Core (Components HtmlElement)) (s "core" </> s "components" </> s "html-element")
            map (Core (Components HtmlTable)) (s "core" </> s "components" </> s "html-table")
            map (Core (Components Hotkeys)) (s "core" </> s "components" </> s "hot-keys")
            map (Core (Components Icon)) (s "core" </> s "components" </> s "icon")
            map (Core (Components Menu)) (s "core" </> s "components" </> s "menu")
            map (Core (Components Navbar)) (s "core" </> s "components" </> s "navbar")
            map (Core (Components NonIdealState)) (s "core" </> s "components" </> s "non-ideal-state")
            map (Core (Components OverflowList)) (s "core" </> s "components" </> s "overflow-list")
            map (Core (Components PanelStack)) (s "core" </> s "components" </> s "panel-stack")
            map (Core (Components ProgressBar)) (s "core" </> s "components" </> s "progress-bar")
            map (Core (Components ResizeSensor)) (s "core" </> s "components" </> s "resize-sensor")
            map (Core (Components Skeleton)) (s "core" </> s "components" </> s "skeleton")
            map (Core (Components Spinner)) (s "core" </> s "components" </> s "spinner")
            map (Core (Components Tabs)) (s "core" </> s "components" </> s "tabs")
            map (Core (Components Tag)) (s "core" </> s "components" </> s "tag")
            map (Core (Components Text)) (s "core" </> s "components" </> s "text")
            map (Core (Components Tree)) (s "core" </> s "components" </> s "tree")


            ////Form Controls
            map (Core (FormControls FormGroup)) (s "core" </> s "form-controls" </> s "form-group" )
            map (Core (FormControls ControlGroup)) (s "core" </> s "form-controls" </> s "control-group" )
            map (Core (FormControls Label)) (s "core" </> s "form-controls" </> s "label" )
            map (Core (FormControls Checkbox)) (s "core" </> s "form-controls" </> s "checkbox" )
            map (Core (FormControls Radio)) (s "core" </> s "form-controls" </> s "radio" )
            map (Core (FormControls HTMLSelect)) (s "core" </> s "form-controls" </> s "html-select" )
            map (Core (FormControls Slider)) (s "core" </> s "form-controls" </> s "slider" )
            map (Core (FormControls Switch)) (s "core" </> s "form-controls" </> s "switch" )

            ////Form Inputs
            map (Core (FormInputs FileInput)) (s "core" </> s "form-inputs" </> s "file-input")
            map (Core (FormInputs NumericInput)) (s "core" </> s "form-inputs" </> s "numeric-input")
            map (Core (FormInputs TextInputs)) (s "core" </> s "form-inputs" </> s "text-inputs")
            map (Core (FormInputs TagInput)) (s "core" </> s "form-inputs" </> s "tag-input")

            // Overlays
            map (Core (Overlays Overlay)) (s "core" </> s "overlays" </> s "overlay")
            map (Core (Overlays Portal)) (s "core" </> s "overlays" </> s "portal")
            map (Core (Overlays Alert)) (s "core" </> s "overlays" </> s "alert")
            map (Core (Overlays ContextMenu)) (s "core" </> s "overlays" </> s "context-menu")
            map (Core (Overlays Dialog)) (s "core" </> s "overlays" </> s "dialog")
            map (Core (Overlays Drawer)) (s "core" </> s "overlays" </> s "drawer")
            map (Core (Overlays Popover)) (s "core" </> s "overlays" </> s "pop-over")
            map (Core (Overlays Toast)) (s "core" </> s "overlays" </> s "toast")
            map (Core (Overlays Tooltip)) (s "core" </> s "overlays" </> s "tooltip")


            map (Core CorePage.Introduction ) top ]

let href route =
    Href (toHash route)

/// Alias for Elmish.Browser.Navigation.modifyUrl
let modifyUrl route =
    route |> toHash |> Navigation.modifyUrl

/// Alias for Elmish.Browser.Navigation.newUrl
let newUrl route =
    route |> toHash |> Navigation.newUrl

/// Alias for Browser.window.location.href
let modifyLocation route =
    Browser.Dom.window.location.href <- toHash route
