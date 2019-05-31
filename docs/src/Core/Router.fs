module Fulma.Router

open Router

let view fulmaPage =
    match fulmaPage with
    | Router.CorePage.Introduction -> Fulma.Introduction.view
    | Router.CorePage.Versions -> Fulma.Versions.view
    | Router.CorePage.Accessibility -> Fulma.Introduction.view
    | Router.CorePage.Classes -> Fulma.Introduction.view
    | Router.CorePage.Colors -> Fulma.Introduction.view
    | Router.CorePage.Typography -> Fulma.Introduction.view
    | Router.CorePage.Variables -> Fulma.Introduction.view
    | Router.Components c ->
        match c with
        | Components.Breadcrumbs -> Components.Breadcrumbs.view
        | _ -> Fulma.Introduction.view
    | _ -> Fulma.Introduction.view
