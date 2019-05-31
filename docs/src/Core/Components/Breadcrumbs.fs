module Components.Breadcrumbs

open Fable.React
open Fable.React.Props
open Fable.BluePrint.Core

let basic () =
    Breadcrumbs.breadcrumbs [
        IBreadcrumbsProps.Items [
            IBreadcrumbProps.Href ""
        ]
    ] []


let view =
    Render.docPage [
        Render.contentFromMarkdown
            """
            # Breadcrumbs
            """
        Render.docSection
            ""
            (Widgets.Showcase.view basic (Render.includeCode __LINE__ __SOURCE_FILE__))
    ]

// let view =
//     Render.docPage [ Render.contentFromMarkdown
//                         """
// # Breadcrumb

// *[Bulma documentation](http://bulma.io/documentation/components/breadcrumb/)*
//                         """
//                      Render.docSection
//                         ""
//                         (Widgets.Showcase.view basic (Render.includeCode __LINE__ __SOURCE_FILE__))

//                     ]