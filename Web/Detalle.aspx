<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Web.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%if (Articulo != null)
        { %>
    <div class="row article-container">
        <div class="col-md-6 col-sm-12 image-container">
            <div id="imageCarousel" class="carousel slide" data-ride="carousel">
                <ol class="carousel-indicators">
                    <%
                        for (int i = 0; i < Articulo.Imagenes.Count; i++)
                        {
                            if (i == 0)
                            {
                    %>
                    <li data-bs-target="#imageCarousel" data-bs-slide-to="<%:i %>" class="active"></li>
                    <%}
                        else
                        {
                    %>
                    <li data-bs-target="#imageCarousel" data-bs-slide-to="<%:i %>"></li>

                    <%  }
                        }

                    %>
                </ol>
                <div class="carousel-inner w-75 mx-auto">

                    <%
                        for (int i = 0; i < Articulo.Imagenes.Count; i++)
                        {
                            if (i == 0)
                            {
                    %>
                    <div class="carousel-item item active">
                        <img src="<%: Articulo.Imagenes[i] %>" class="d-block w-100" alt="...">
                    </div>
                    <%}
                        else
                        {
                    %>
                    <div class="carousel-item item">
                        <img src="<%: Articulo.Imagenes[i] %>" class="d-block w-100" alt="...">
                    </div>

                    <%}
                        }

                    %>
                </div>
                <button class="carousel-control-prev carousel-dark" type="button" data-bs-target="#imageCarousel" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Previous</span>
                </button>
                <button class="carousel-control-next carousel-dark" type="button" data-bs-target="#imageCarousel" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Next</span>
                </button>
            </div>

        </div>


        <div class="col-md-6 col-sm-12 content-container">

            <label class="text-uppercase fs-5"><%:Articulo.Marca %></label>
            <h2 class="text-dark fw-medium display-2"><%:Articulo.Nombre %></h2>
            <p class="text-body-secondary lh-sm"><%:Articulo.Descripcion %></p>

            <div>
                <label>Cantidad:</label>
                <asp:TextBox ID="tBoxCantidad" TextMode="Number" runat="server" min="1" max="50" step="1" />
            </div>

            <label class="text-dark fs-3">$<%:Articulo.Precio %></label>

            <div>
                <a href="Default.aspx" class="btn btn-danger">Volver</a>
                <asp:Button ID="btnAgregarCarrito" OnClick="btnAgregarCarrito_Click" CssClass="btn btn-success" runat="server" Text="Agregar al carrito" />
            </div>

        </div>


    </div>
    <%}
    else
    {  %>
    <p>Cargando....</p>
    <%} %>

    <style>
        .article-container {
            margin-top: 50px;
        }
        .carousel-item{
            height: 500px;  
        }
        .image-container img {
            height: 100%;
            width: 100%;
            object-fit: cover;
        }
        .content-container {
            padding: 50px 50px 0px 50px;
            display: flex;
            flex-direction: column;
            gap: 20px;
        }
        .carousel-indicators li::marker{font-size:0;}
        
    </style>
</asp:Content>
