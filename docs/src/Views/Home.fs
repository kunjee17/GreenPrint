module Home
// ![Fulma logo](assets/logo_transparent.svg) //TODO: logo
let view =
    Render.contentFromMarkdown
        """
<center style="width: 200px;margin: auto;">
</center>

# Fulma

Fulma provides a wrapper around [Blueprint](https://blueprintjs.com), an open source CSS framework, for [fable-react](https://github.com/fable-compiler/fable-react).

Fulma is divided into 3 projects:

- [Core](#core), which provides you with a wrapper on top of Blueprint.Core
- [Datetime](#datetime), which provides you with a wrapper on top of Blueprint.Datetime
- [Icons](#icons), which provides you with a wrapper on top of Blueprint.Icons
- [Select](#select), which provides you with a wrapper on top of Blueprint.Select
- [Table](#table), which provides you with a wrapper on top of Blueprint.Table
- [Timezone](#timezone), which provides you with a wrapper on top of Blueprint.Timezone
        """
