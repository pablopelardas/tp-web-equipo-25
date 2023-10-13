<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Web.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Error <asp:Literal ID="Status" runat="server"></asp:Literal></h2>
    <div>
        Ocurrio un error al procesar su solicitud.
        <asp:Literal ID="Message" runat="server"></asp:Literal>
    </div>

</asp:Content>
