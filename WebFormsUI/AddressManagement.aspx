<%@ Page Title="" Language="C#" MasterPageFile="~/AnaEkran.Master" AutoEventWireup="true" CodeBehind="AddressManagement.aspx.cs" Inherits="WebFormsUI.AddressManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body{
            /*background-color: red;
            color: white;*/
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Adres Yönetimi</h1>
    <asp:GridView ID="dgvAdresler" runat="server"></asp:GridView>
    <hr />
    <div>

    </div>
</asp:Content>
