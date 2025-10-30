@page "{id:int}"
@model EditModel
<h2>Editar Contato</h2>

<form method="post">
    <div asp-validation-summary="ModelOnly"></div>
    <input asp-for="Contato.Nome" class="form-control" />
    <input asp-for="Contato.Telefone" class="form-control" />
    <input asp-for="Contato.Email" class="form-control" />
    <input asp-for="Contato.DataNascimento" class="form-control" type="date" />
    <input asp-for="Contato.Foto" class="form-control" />
    <button type="submit" class="btn btn-primary">Salvar</button>
</form>
