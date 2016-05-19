﻿@ModelType IEnumerable(Of Tuple(Of String, String))

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>

    <head>
        <meta name="viewport" content="width=device-width" />
        <title>Device Capabilities</title>
        <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
        <link href="~/Content/bootstrap-theme.min.css" rel="stylesheet" />
    </head>

    <body class="container">

        <div class="panel panel-primary">

            <div class="panel-heading">Capabilities</div>

            <table class="table table-striped table-bordered">
                <tr><th>Property</th><th>Value</th></tr>
                <tr><td>Browser</td><td>@Request.Browser.Browser</td></tr>
                <tr><td>IsMobileDevice</td><td>@Request.Browser.IsMobileDevice</td></tr>
                <tr>
                    <td>MobileDeviceManufacturer</td>
                    <td>@Request.Browser.MobileDeviceManufacturer</td>
                </tr>
                <tr>
                    <td>MobileDeviceModel</td>
                    <td>@Request.Browser.MobileDeviceModel</td>
                </tr>
                <tr>
                    <td>ScreenPixelsHeight</td>
                    <td>@Request.Browser.ScreenPixelsHeight</td>
                </tr>
                <tr>
                    <td>ScreenPixelsWidth</td>
                    <td>@Request.Browser.ScreenPixelsWidth</td>
                </tr>
                <tr><td>Version</td><td>@Request.Browser.Version</td></tr>
                <tr><td>CssColumn</td><td>@Request.Browser("CssColumn")</td></tr>
                <tr><td>CssFlexbox</td><td>@Request.Browser("CssFlexbox")</td></tr>
            </table>

        </div>

    </body>

</html>
