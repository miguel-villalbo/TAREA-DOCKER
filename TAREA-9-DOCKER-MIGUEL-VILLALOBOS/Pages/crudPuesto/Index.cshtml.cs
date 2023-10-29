@page
@model Tarea_9_Docker.Pages.crudPuesto.IndexModel

<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Lista de Puestos</title>
</head>
<body>

<div class="container mt-3">
    <h3>Lista de Puestos</h3>
    <hr />

    <p>
        <a asp-page="Create" class="btn btn-primary">Crear Nuevo</a>
    </p>

    <table class="table table-striped">
        <thead>
            <tr>
                <th>Nombre del Puesto</th>
                <th>Acciones</th>
            </tr>
        </thead>
        <tbody>
            @foreach (var puesto in Model.Puesto)
            {
                <tr>
                    <td>@puesto.nombrePuesto</td>
                    <td>
                        <a asp-page="./Edit" asp-route-id="@puesto.idPuesto" class="btn btn-sm btn-warning">Editar</a>
                        <a asp-page="./Details" asp-route-id="@puesto.idPuesto" class="btn btn-sm btn-info">Detalles</a>
                        <a asp-page="./Delete" asp-route-id="@puesto.idPuesto" class="btn btn-sm btn-danger">Eliminar</a>
                    </td>
                </tr>
            }
        </tbody>
    </table>
</div>

</body>
</html>
