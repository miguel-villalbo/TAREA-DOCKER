@page
@model Tarea_9_Docker.Pages.crudPuesto.EditModel

<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Editar Puesto</title>
</head>
<body>

<div class="container mt-3">
    <h3>Editar Puesto</h3>
    <hr />

    <form method="post">
        <div asp-validation-summary="ModelOnly" class="text-danger"></div>
        <input type="hidden" asp-for="Puesto.idPuesto" />

        <div class="form-group">
            <label asp-for="Puesto.nombrePuesto" class="control-label">Nombre del Puesto</label>
            <input asp-for="Puesto.nombrePuesto" class="form-control" />
            <span asp-validation-for="Puesto.nombrePuesto" class="text-danger"></span>
        </div>

        <button type="submit" class="btn btn-primary">Guardar</button>
        <a asp-page="./Index" class="btn btn-secondary">Volver a la Lista</a>
    </form>
</div>

@section Scripts {
    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
}

</body>
</html>
