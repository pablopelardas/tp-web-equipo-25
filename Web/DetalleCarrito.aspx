<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleCarrito.aspx.cs" Inherits="Web.DetalleCarrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid mt-5">
        <div class="carrito row">
            <div class="articulos col-md-6">
                <asp:Repeater runat="server" ID="repRepetidor">
                    <ItemTemplate>
                        <div class="card mb-2">
                            <asp:HiddenField ID="hfId" runat="server" Value='<%#Eval("Articulo.Id")%>' />
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

                                <div class="col-2">

                                    <div>
                                        <label>Cantidad:</label>
                                        <asp:TextBox ID="cantidad_TextBox" Text='<%#Eval("Cantidad")%>' TextMode="Number" OnTextChanged="Cantidad_TextChanged" runat="server" AutoPostBack="true"></asp:TextBox>
                                    </div>

                                    <asp:ImageButton CommandArgument='<%#Eval("Articulo.Id")%>' CommandName="deseadoId" CssClass="btn btn-danger" OnClick="ImagBtnEliminar_Click" ImageUrl="~/Image/trash3.svg" runat="server" />

                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="detalle col-md-6">
                <h2 class="mb-3">Detalle de compra</h2>
                <h3>Total = <asp:Literal ID="totalLiteral" runat="server"></asp:Literal></h3>
            </div>
        </div>
    </div>

</asp:Content>
