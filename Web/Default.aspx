<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row m-4 mx-auto w-50">

        <div class="col-6">
            <asp:DropDownList ID="ddlMarca" CssClass="form-select mx-auto w-auto" runat="server"></asp:DropDownList>
        </div>
        <div class="col-6">
            <asp:DropDownList ID="ddlCategoria" CssClass="form-select mx-auto w-auto" runat="server"></asp:DropDownList>
        </div>

    </div>

    <div class="row">

        <%
            foreach (Dominio.Categoria item in ListaCategorias)
            {
        %>
                <div class="row">
                    <div style="display: flex; flex-direction: column;">
                        <h3><%: item.Nombre %></h3>
                        <div style="display: flex; gap: 10px">
                            <%
                                foreach (Dominio.Articulo art in ListaArticulos.FindAll(a => a.Categoria.Nombre == item.Nombre))
                                {
                            %>
                                    <div class="card" style="max-width: 400px;">
                                        <img src="<%:art.Imagenes[0] %>" class="card-img-top" alt="...">
                                        <div class="card-body">
                                            <h5 class="card-title"><%: art.Nombre %></h5>
                                            <p class="card-text"><%: art.Descripcion %></p>
                                            <a href="Detalle.aspx?id=<%: art.Id %>" class="btn btn-outline-dark">Ver Detalle</a>
                                            <a href="#" class="btn btn-outline-dark">Agregar al carrito</a>
                                        </div>
                                    </div>
                            <%  } %>
                        </div>

                    </div>
                </div>
        <%  } %>
    </div>




</asp:Content>
