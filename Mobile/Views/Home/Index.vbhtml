@Imports Mobile.Mobile.Models

@ModelType Programmer()

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>

    <head>
        <meta name="viewport" content="width=device-width" />
        <title>Mobile Devices</title>
        <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
        <link href="~/Content/bootstrap-theme.min.css" rel="stylesheet" />
        <style>
            body {
                padding-top: 10px;
            }
        </style>
    </head>

    <body>

        <div class="alert alert-success">
            This is the /Views/Home/Index.vbhtml view
        </div>

        <div class="panel panel-primary">

            <div class="panel-heading">Programadores</div>

            <table class="table table-striped">

                <tr> <th>Nombre</th><th>Apellidos</th><th>Titulo</th> <th>Ciudad</th><th>Pais</th><th>Lenguaje</th> </tr>
        
                @For Each prog As Programmer In Model

                    @<tr>
                        <td>@prog.Nombre</td> <td>@prog.Apellidos</td> <td>@prog.Titulo</td> <td>@prog.Ciudad</td> <td>@prog.Pais</td> <td>@prog.Lenguaje</td>
                    </tr>

                Next

            </table>

        </div>

    </body>

</html>
