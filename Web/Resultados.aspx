<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resultados.aspx.cs" Inherits="Web.Resultados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <asp:Repeater ID="rptArticulosFiltrados" runat="server">
            <ItemTemplate>
                <div class="card">
                    <div class="card-header">
                        <%# Eval("Nombre") %>
                    </div>
                    <div class="card-body">
                        <%# Eval("Descripcion") %>
                    </div>
                    <div class="card-footer">
                        <%# Eval("Precio") %>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
</asp:Content>
