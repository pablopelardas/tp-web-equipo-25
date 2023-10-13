<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resultados.aspx.cs" Inherits="Web.Resultados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container" style="margin-top: 30px;">

        <div class="col" style="width: 100px">
            <%--filtros--%>
        </div>

        <div class="col">
            <asp:Repeater ID="rptArticulosFiltrados" runat="server">
                <ItemTemplate>

                    <div class="card mb-3">
                        <div class="row g-0">
                            <div class="col-md-4">
                                <img src="..." class="img-fluid rounded-start" alt="...">
                            </div>
                            <div class="col-md-8">
                                <div class="card-body">
                                    <h4 class="card-title"><%# Eval("Nombre") %></h4>
                                    <p class="card-text"><%# Eval("Descripcion") %></p>
                                    <h5>$<%# Eval("Precio") %></h5>
                                </div>
                                <div class="text-end" style="margin-right: 15px; margin-bottom: 15px">
                                    <a href="Detalle.aspx?id=<%# Eval("Id")%>" class="btn btn-outline-dark">Ver Detalle</a>
                                </div>
                            </div>
                        </div>
                    </div>


                    <div class="card">
                    </div>
                </ItemTemplate>
            </asp:Repeater>


        </div>

    </div>



</asp:Content>
