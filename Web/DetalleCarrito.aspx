<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleCarrito.aspx.cs" Inherits="Web.DetalleCarrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="mx-auto">

        <label>Detalle de compra</label>

        <%
            foreach (Dominio.Carrito car in ListaCarrito)
            {
        %>

                <div class="card mb-2">

                    <div class="row g-0">

                        <div class="col-2">
                            <img src="<%: car.Imagen %>" class="w-100 h-100" alt="...">
                        </div>

                        <div class="col-8">
                            <div class="card-body">

                                <asp:Label ID="lblId" runat="server" Text=""></asp:Label>

                                <label><%: car.Nombre %></label>
                                <label><%: car.Descripcion %></label>
                                <label><%: car.Precio %></label>

                            </div>
                        </div>

                        <div class="col-2 text-center py-5">

                            <div>
                                <label>Cantidad:</label>
                                <input type="number" min="1" max="50" step="1" value="<%: car.Cantidad %>" />
                            </div>

                            <div class="btn btn-danger">
                                <asp:ImageButton ID="ImagBtnEliminar" OnClick="ImagBtnEliminar_Click" ImageUrl="~/Image/trash3.svg" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>

        <%  } %>
    </div>

</asp:Content>
