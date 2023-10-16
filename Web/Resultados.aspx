<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resultados.aspx.cs" Inherits="Web.Resultados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container" style="margin: 30px;">
        <%--ver de agregar 1 de ... resultados--%>
        <div class="row">
            <div class="col-3">
                <h4>Filtros</h4>
                <div>
                    <div class="badge rounded-pill text-bg-secondary" id="divBuscado" runat="server">
                        <asp:Label Text="" ID="textoBuscado" runat="server" />
                        <a href="Default.aspx" class="cancelarBuscar">x</a>
                    </div>
                    <div class="badge rounded-pill text-bg-secondary" id="divCat" Visible="false" runat="server">
                        <asp:Label Text="" ID="catBuscado" runat="server" />
                    </div>
                    <div class="badge rounded-pill text-bg-secondary" id="divMrc" Visible="false" runat="server">
                        <asp:Label Text="" ID="mrcBuscado" runat="server" />
                    </div>
                </div>
                <div class="mb-3">
                    <label for="filtroCategoria">Categoría</label>
                    <asp:DropDownList ID="filtroCategoria" CssClass="form-select h-1" runat="server" AutoPostBack="false"></asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label for="filtroCategoria">Marca</label>
                    <asp:DropDownList ID="filtroMarca" CssClass="form-select h-1" runat="server" AutoPostBack="false"></asp:DropDownList>
                </div>
                <asp:Button ID="btnFiltro" Text="Aplicar filtro" OnClick="btnFiltro_Click" CssClass="btn btn-primary" runat="server" />
            </div>

            <div class="col-9">
                <asp:Repeater ID="rptArticulosFiltrados" runat="server">
                    <ItemTemplate>

                        <div class="card">
                            <div class="row g-0">
                                <div class="col-md-4">
                                    <img src="..." class="img-fluid rounded-start" alt="...">
                                </div>
                                <div class="col-md-8">
                                    <div class="card-body">
                                        <h4 class="card-title"><%# Eval("Nombre") %></h4>
                                        <p class="card-text"><%# Eval("Descripcion") %></p>
                                        <h5>$<%# Eval("Precio") %></h5>
                                    </div>
                                    <div class="text-end" style="margin-right: 15px; margin-bottom: 15px">
                                        <a href="Detalle.aspx?id=<%# Eval("Id")%>" class="btn btn-outline-dark">Ver Detalle</a>
                                    </div>
                                </div>
                            </div>
                        </div>


                        <div class="card">
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
        </div>

    </div>

    <style>
        .cancelarBuscar {
            color:white;
            margin-left:2px;
        }

    </style>

</asp:Content>

