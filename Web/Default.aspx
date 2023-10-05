<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row m-4 mx-auto w-50">

        <div class="col-6">
            <asp:DropDownList ID="ddlMarca" CssClass="form-select mx-auto w-auto" runat="server"></asp:DropDownList>
        </div>
        <div class="col-6">         
            <asp:DropDownList ID="ddlCategoria" CssClass="form-select mx-auto w-auto" runat="server"></asp:DropDownList>
        </div>

    </div>




</asp:Content>
