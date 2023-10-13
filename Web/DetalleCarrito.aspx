<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleCarrito.aspx.cs" Inherits="Web.DetalleCarrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container mt-5">
        <div class="carrito row">
            <div class="contenedor-articulos col-md-6">
                <asp:Repeater runat="server" ID="repRepetidor">
                    <ItemTemplate>
                        <div class="articulo">
                            <asp:HiddenField ID="hfId" runat="server" Value='<%#Eval("Articulo.Id")%>' />
                            <div class="articulo-imagen">
                                <img src='<%#Eval("Articulo.Imagenes[0]")%>' class="w-100 h-100" alt="...">
                            </div>
                            <div class="articulo-detalle">
                                <div class="detalle-info">

                                    <asp:Label ID="lblId" runat="server" Text=""></asp:Label>

                                    <label><%#Eval("Articulo.Nombre")%></label>
                                    <label><%#Eval("Articulo.Descripcion")%></label>
                                    <label><%#Eval("Articulo.Precio")%></label>

                                </div>
                                <div class="detalle-cantidad">
                                    <label>Cantidad:</label>
                                    <asp:TextBox ID="cantidad_TextBox" Text='<%#Eval("Cantidad")%>' TextMode="Number" OnTextChanged="Cantidad_TextChanged" runat="server" AutoPostBack="true"></asp:TextBox>
                                    <asp:ImageButton CommandArgument='<%#Eval("Articulo.Id")%>' CommandName="deseadoId" CssClass="btn btn-danger" OnClick="ImagBtnEliminar_Click" ImageUrl="~/Image/trash3.svg" runat="server" />
                                </div>

                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="info col-md-6">
                <h2 class="mb-3">Detalle de compra</h2>
                <h3>Total = $
                    <asp:Literal ID="totalLiteral" runat="server"></asp:Literal></h3>
            </div>
        </div>
    </div>

    <style>

        .articulo {
            display: flex;
            flex-direction: row;
            justify-content: space-between;
            align-items: center;
            margin-bottom: 20px;
            border-bottom: 1px solid #ccc;
            padding-bottom: 20px;
            gap: 20px;
            height: 200px;
        }

        .articulo-imagen {
            width: 200px;
            height: 200px;
        }

        .articulo-imagen img {
            width: 100%;
            height: 100%;
            -o-object-fit: cover;
            object-fit: cover;
        }

        .articulo-detalle {
            display: flex;
            flex-direction: column;
            width: 100%;
            height: 100%;
        }

        .detalle-info {
            display: flex;
            flex-direction: column;
            justify-content: space-between;
            height: 100%;
        }

        .detalle-cantidad {
            display: flex;
            flex-direction: row;
            justify-content: flex-end;
            align-items: center;
            gap: 20px;
        }

        .detalle-cantidad label {
            margin-right: 10px;
        }

        .detalle-cantidad input {
            width: 50px;
        }

        .detalle-cantidad input[type="number"]::-webkit-inner-spin-button,
        .detalle-cantidad input[type="number"]::-webkit-outer-spin-button {
            -webkit-appearance: none;
            margin: 0;
        }
    </style>

</asp:Content>
