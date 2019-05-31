module Fulma.Versions

let view =
    Render.contentFromMarkdown
        """
<center style="width: 200px;margin: auto;">
    ![Fulma logo](assets/logo_transparent.svg)
</center>

Here you can find which version of each library is supported by Greenprint.

<table class="bp3-html-table bp3-html-table-bordered bp3-html-table-condensed bp3-html-table-striped" style="width: auto;">
    <thead>
        <tr>
            <th>Module</th>
            <th>GreenPrint</th>
            <th>BluePrint</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Core</td>
            <td>0.1.7</td>
            <td>3.15.1</td>
        </tr>
        <tr>
            <td>Datetime</td>
            <td>Coming Soon</td>
            <td>Coming Soon</td>
        </tr>
        <tr>
            <td>Icons</td>
            <td>0.1.5</td>
            <td>3.9.0</td>
        </tr>
        <tr>
            <td>Select</td>
            <td>Coming Soon</td>
            <td>Coming Soon</td>
        </tr>
        <tr>
            <td>Table</td>
            <td>Coming Soon</td>
            <td>Coming Soon</td>
        </tr>
        <tr>
            <td>Timezone</td>
            <td>Coming Soon</td>
            <td>Coming Soon</td>
        </tr>
    </tbody>
<table>
        """
