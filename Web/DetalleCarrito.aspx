<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleCarrito.aspx.cs" Inherits="Web.DetalleCarrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="mx-auto">

        <label>Detalle de compra</label>

        <asp:Repeater runat="server" ID="repRepetidor">
            <ItemTemplate>
                <div class="card mb-2">

                    <div class="row g-0">

                        <div class="col-2">
                            <img src='<%#Eval("Articulo.Imagenes[0]")%>' class="w-100 h-100" alt="...">
                        </div>

                        <div class="col-8">
                            <div class="card-body">

                                <asp:Label ID="lblId" runat="server" Text=""></asp:Label>

                                <label><%#Eval("Articulo.Nombre")%></label>
                                <label><%#Eval("Articulo.Descripcion")%></label>
                                <label><%#Eval("Articulo.Precio")%></label>

                            </div>
                        </div>

                        <div class="col-2 text-center py-5">

                            <div>
                                <label>Cantidad:</label>
                                <input type="number" min="1" max="50" step="1" value='<%#Eval("Cantidad")%>' />
                            </div>

                            <div class="btn btn-danger">
                                <asp:ImageButton ID="ImagBtnEliminar" CommandArgument='<%#Eval("Articulo.Id")%>' CommandName="deseadoId" OnClick="ImagBtnEliminar_Click" ImageUrl="~/Image/trash3.svg" runat="server" AutoPostBack="False"/>
                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </div>

</asp:Content>
