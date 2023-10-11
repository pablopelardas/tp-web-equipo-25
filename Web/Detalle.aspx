<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Web.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-6">

            <div id="carouselExampleIndicators" class="carousel slide">
                <div class="carousel-indicators">
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
                </div>
                <div class="carousel-inner w-75 mx-auto">

                    <%
                        foreach (Dominio.Articulo art in ListaArticulos.FindAll(a => a.Id == Id))
                        {
                    %>
                            <%
                                for (int i = 0; i < art.Imagenes.Count; i++)
                                {
                            %>
                                    <div class="carousel-item active">
                                        <img src="<%: art.Imagenes[i] %>" class="d-block w-100" alt="...">
                                    </div>
                            <%  }  %>

                    <%  }  %>
                </div>
                <button class="carousel-control-prev carousel-dark" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Previous</span>
                </button>
                <button class="carousel-control-next carousel-dark" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Next</span>
                </button>
            </div>

        </div>


        <div class="col-6">

            <%
                foreach (Dominio.Articulo art in ListaArticulos.FindAll(a => a.Id == Id))
                {
            %>
                    <label class="text-uppercase fs-5"><%:art.Marca %></label>
                    <h2 class="text-dark fw-medium display-2"><%:art.Nombre %></h2>
                    <p class="text-body-secondary lh-sm"><%:art.Descripcion %></p>

                    <div>
                        <label>Cantidad:</label>
                        <asp:TextBox ID="tBoxCantidad" TextMode="Number" runat="server" min="0" max="50" step="1"/>
                    </div>

                    <label class="text-dark fs-3">$<%:art.Precio %></label>
           
                    <div>
                        <a href="Default.aspx" class="btn btn-danger">Volver</a>
                        <asp:Button ID="btnAgregarCarrito" OnClick="btnAgregarCarrito_Click" CssClass="btn btn-success" runat="server" Text="Agregar al carrito" />
                    </div>

            <%  }  %>
        </div>


    </div>




</asp:Content>
