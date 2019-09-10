<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgretmenListele.aspx.cs" Inherits="OgretmenListele" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <%--   <a href="Default.aspx" class="btn btn-info">ÖĞRENCİ EKLE </a>--%>
    <table class="table table-bordered table-hover">


        <tr>
            <th>ĞRETMEN ID</th>
            <th>ÖĞRETMEN AD-SOYAD</th>
            <th>ÖĞRETMEN BRANŞ</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("OGRTID")%></td>
                        <td><%# Eval(" OGRTADSOYAD")%></td>
                        <td><%# Eval("OGRTBRANS")%></td>

                      <%--  
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"~/OgrenciSilme.aspx?OGRID="+Eval("OgrId") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">SİL </asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"~/OgrenciGüncelle.aspx?OGRID="+Eval("OgrId") %>' ID="HyperLink2" runat="server" CssClass="btn btn-info">GÜNCELLE</asp:HyperLink>
                        </td>--%>

                    </tr>

                </ItemTemplate>

            </asp:Repeater>

        </tbody>

    </table>

</asp:Content>

