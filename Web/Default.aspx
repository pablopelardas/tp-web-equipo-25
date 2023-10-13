<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container" style="margin-top: 30px;">

        <%
            foreach (Dominio.Categoria item in ListaCategorias)
            {
        %>
                <div class="row">
                    <div class="categoria-container">
                        <h3><%: item.Nombre %></h3>
                        <div class="items-container">
                            <%
                                foreach (Dominio.Articulo art in ListaArticulos.FindAll(a => a.Categoria.Nombre == item.Nombre))
                                {
                            %>
                                    <div class="card">
                                        <img src="<%:art.Imagenes[0] %>" class="card-img-top" alt="...">
                                        <div class="card-body">
                                            <h5 class="card-title"><%: art.Nombre %></h5>
                                            <p class="card-text">S/. $<%: art.Precio %></p>
                                            <a href="Detalle.aspx?id=<%: art.Id %>" class="btn btn-outline-dark">Ver Detalle</a>
                                        </div>
                                    </div>
                            <%  } %>
                        </div>

                    </div>
                </div>
        <%  } %>
    </div>

    <style>
        .categoria-container {
            display: flex; 
            flex-direction: column;
            -ms-flex-wrap: wrap;
            -webkit-flex-wrap: wrap;
            flex-wrap: wrap;
        }
        .items-container{
            display: flex;
            flex-direction: row;
            flex-wrap: wrap;
        }
        .categoria-container .card{
            width: 20%;
            height: 500px;
            margin: 10px 0px;
        }
.categoria-container .card img{
            height: 300px;
        }

        .categoria-container .card .card-body{
            display: flex;
            flex-direction: column;
            justify-content: space-between;
            height: 150px;   
        }

    </style>

</asp:Content>
