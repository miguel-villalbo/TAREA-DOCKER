@page
@model Tarea_9_Docker.Pages.crudPuesto.DetailsModel

<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Details</title>
</head>
<body>

<div class="container">
    <h4 class="mt-3">Puesto</h4>
    <hr />

    <dl class="row">
        <dt class="col-sm-3">Nombre:</dt>
        <dd class="col-sm-9">@Model.Puesto.nombrePuesto</dd>
    </dl>
</div>

<div class="container mt-4">
    <a class="btn btn-primary" asp-page="./Edit" asp-route-id="@Model.Puesto?.idPuesto">Edit</a>
    <a class="btn btn-secondary" asp-page="./Index">Back to List</a>
</div>

</body>
</html>
