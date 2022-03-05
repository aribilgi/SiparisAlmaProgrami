<%@ Page Title="" Language="C#" MasterPageFile="~/AnaEkran.Master" AutoEventWireup="true" CodeBehind="ProductManagement.aspx.cs" Inherits="WebFormsUI.ProductManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Ürün Yönetimi</h1>
    <asp:GridView ID="dgvUrunler" runat="server"></asp:GridView>
    <hr />
    <div>

        <table class="auto-style1">
            <tr>
                <td>Ürün Adı</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Açıklama</td>
                <td>
                    <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Stok</td>
                <td>
                    <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Fiyat</td>
                <td>
                    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Kategori</td>
                <td>
                    <asp:DropDownList ID="cbKategoriler" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Durum</td>
                <td>
                    <asp:CheckBox ID="cbIsActive" runat="server" Text="Aktif" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnEkle" runat="server" Text="Ekle" OnClick="btnEkle_Click" />
                    <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" />
                    <asp:Button ID="btnSil" runat="server" Text="Sil" />
                </td>
            </tr>
        </table>

    </div>

</asp:Content>
