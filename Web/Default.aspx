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

    <div class="row row-cols-1 row-cols-md-3 g-4">
        <p>TEST</p>
<%--        <%
            foreach (Dominio.Articulo item in ListaArticulos)
            {
        %>
                <div class="col">
                    <div class="card">
                        <%foreach (Dominio.Imagen i in ListaImagenes)
                            {
                                if (i.IdArticulo == item.Id)
                                {
                                    ImgSeleccionada = i.URL;
                                }
                            } %>
                        <img src="<%: ImgSeleccionada %>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title"><%: item.Nombre %></h5>
                            <p class="card-text"><%: item.Descripcion %></p>
                        </div>
                    </div>
                </div>
        <%  } %>--%>

    </div>




</asp:Content>
