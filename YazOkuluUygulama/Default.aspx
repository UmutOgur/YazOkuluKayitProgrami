<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <strong>
                <asp:Label for="TxtAd" runat="server" Text="ÖĞRENCİ ADI" ></asp:Label>
                </strong>
                <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtSoyad" runat="server" Text="ÖĞRENCİ SOYADI"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtNumara" runat="server" Text="ÖĞRENCİ NUMARA"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtSifre" runat="server" Text="ÖĞRENCİ ŞİFRE"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control" type="Password"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtFotograf" runat="server" Text="ÖĞRENCİ FOTOĞRAF"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtFotograf" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <%--<div>
                <strong>
                <asp:Label for="TxtBakiye" runat="server" Text="ÖĞRENCİ BAKİYE"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtBakiye" runat="server" CssClass="form-control"></asp:TextBox>
            </div>--%>
        </div>
        <asp:Button ID="Button1" runat="server" Text="ÖĞRENCİ EKLE" OnClick="Button1_Click" CssClass="btn btn-info" />
    </form>

</asp:Content>
