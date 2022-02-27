<%@ Page Title="" Language="C#" MasterPageFile="~/AnaEkran.Master" AutoEventWireup="true" CodeBehind="ProductManagement.aspx.cs" Inherits="WebFormsUI.ProductManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Ürün Yönetimi</h1>
    <asp:GridView ID="dgvUrunler" runat="server"></asp:GridView>
    <hr />
    <div>

    </div>

</asp:Content>
