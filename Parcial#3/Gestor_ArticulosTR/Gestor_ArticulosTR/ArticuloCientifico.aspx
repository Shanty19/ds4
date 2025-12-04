<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ArticuloCientifico.aspx.cs" Inherits="Gestor_ArticulosTR.ArticuloCientifico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Encabezado -->
    <div class="container mt-4">
        <div class="card shadow-lg">
            <div class="card-body text-center bg-primary text-white rounded-top">
                <h2 class="fw-bold">Sistema Gestor de Artículos Científicos</h2>
                <p class="mb-0">Bienvenido/a — Universidad Tecnológica de Panamá</p>
            </div>
        </div>
    </div>


    <!-- FORMULARIO COMPLETO -->
    <div class="container mt-4">
        <div class="card shadow">
            <div class="card-header bg-dark text-white">
                <h5 class="mb-0">Formulario de Registro</h5>
            </div>

            <div class="card-body">

                <!-- MENSAJE -->
                <asp:Label ID="lblMensaje" CssClass="h5 text-success" runat="server"></asp:Label>
                <hr />

                <!-- FORMULARIO DE REVISTA -->
                <h5 class="text-primary">Registrar Revista</h5>
                <div class="row">
                    <div class="col-md-6">
                        <asp:TextBox ID="txtRevistaNombre" CssClass="form-control" placeholder="Nombre de la revista" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <asp:Button ID="btnGuardarRevista" CssClass="btn btn-primary w-100" Text="Guardar Revista" runat="server" OnClick="btnGuardarRevista_Click" />
                    </div>
                </div>

                <hr />

                <!-- FORMULARIO DE AUTOR -->
                <h5 class="text-primary">Registrar Autor</h5>
                <div class="row mb-2">
                    <div class="col-md-3">
                        <asp:TextBox ID="txtAutorNombre" CssClass="form-control" placeholder="Nombre" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <asp:TextBox ID="txtAutorApellido" CssClass="form-control" placeholder="Apellido" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <asp:TextBox ID="txtORCID" CssClass="form-control" placeholder="ORCID" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <asp:TextBox ID="txtAfiliacion" CssClass="form-control" placeholder="Afiliación" runat="server"></asp:TextBox>
                    </div>
                </div>

                <asp:Button ID="btnGuardarAutor" CssClass="btn btn-primary" Text="Guardar Autor" runat="server" OnClick="btnGuardarAutor_Click" />

                <hr />

                <!-- FORMULARIO DE ARTÍCULO -->
                <h5 class="text-primary">Registrar Artículo Científico</h5>

                <div class="row mb-2">
                    <div class="col-md-6">
                        <asp:TextBox ID="txtTitulo" CssClass="form-control" placeholder="Título del artículo" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <asp:TextBox ID="txtAnio" CssClass="form-control" placeholder="Año de publicación" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <asp:TextBox ID="txtDOI" CssClass="form-control" placeholder="DOI" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="row mb-2">
                    <div class="col-md-12">
                        <asp:TextBox ID="txtResumen" CssClass="form-control" placeholder="Resumen" TextMode="MultiLine" Rows="3" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="row mb-2">
                    <div class="col-md-6">
                        <asp:DropDownList ID="ddlRevistas" CssClass="form-control" runat="server"></asp:DropDownList>
                    </div>
                    <div class="col-md-6">
                        <asp:DropDownList ID="ddlAutores" CssClass="form-control" runat="server"></asp:DropDownList>
                    </div>
                </div>

                <asp:Button ID="btnGuardarArticulo" CssClass="btn btn-success" Text="Guardar Artículo" runat="server" OnClick="btnGuardarArticulo_Click" />

            </div>
        </div>
    </div>


    <!-- TABLA DE ARTÍCULOS -->
    <div class="container mt-4">
        <div class="card shadow-sm">
            <div class="card-header bg-secondary text-white">
                <h5 class="mb-0"> Artículos recientemente registrados</h5>
            </div>
            <div class="card-body">

                <asp:GridView ID="gvArticulos" runat="server"
                    CssClass="table table-striped table-hover"
                    AutoGenerateColumns="False" 
                    EmptyDataText="No hay artículos registrados aún.">

                    <Columns>
                        <asp:BoundField DataField="Titulo" HeaderText="Título" />
                        <asp:BoundField DataField="Autor" HeaderText="Autor" />
                        <asp:BoundField DataField="Revista" HeaderText="Revista" />
                        <asp:BoundField DataField="Anio" HeaderText="Año" />
                    </Columns>

                </asp:GridView>

            </div>
        </div>
    </div>

</asp:Content>
