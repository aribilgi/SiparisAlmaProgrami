<%@ Page Title="" Language="C#" MasterPageFile="~/AnaEkran.Master" AutoEventWireup="true" CodeBehind="AddressManagement.aspx.cs" Inherits="WebFormsUI.AddressManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            /*background-color: red;
            color: white;*/
        }

        table {
            min-width: 500px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Adres Yönetimi</h1>
    <asp:GridView ID="dgvAdresler" runat="server"></asp:GridView>
    <hr />

    <table>
        <tr>
            <td>Başlık</td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Açık Adres
            </td>
            <td>
                <asp:TextBox ID="txtOpenAddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Müşteri
            </td>
            <td>
                <asp:DropDownList ID="cbCustomers" runat="server" DataTextField="Name" DataValueField="Id"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnEkle" runat="server" Text="Ekle" OnClick="btnEkle_Click" />
                <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" />
                <asp:Button ID="btnSil" runat="server" Text="Sil" />
            </td>
        </tr>
    </table>

</asp:Content>
