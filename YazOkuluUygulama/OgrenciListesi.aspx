<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciListesi.aspx.cs" Inherits="OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

     <%-- <a href="Default.aspx" class="btn btn-info">ÖĞRENCİ EKLE </a>--%>
    <table class="table table-bordered table-hover">
     
        
        <tr>
            <th>ÖĞRENCİ ID</th>
            <th>ÖĞRENCİ AD</th>
            <th>ÖĞRENCİ SOYAD</th>
            <th>ÖĞRENCİ NUMARA</th>
            <th>ÖĞRENCİ ŞİFRE</th>
            <th>ÖĞRENCİ FOTOĞRAF</th>
            <th>ÖĞRENCİ BAKİYE</th>
            <th>İŞLEMLER</th>

        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("OgrId")%></td>
                        <td><%# Eval("OrgAd")%></td>
                        <td><%# Eval("OgrSoyad")%></td>
                        <td><%# Eval("OgrNumara")%></td>
                        <td><%# Eval("OgrSifre")%></td>
                        <td><%# Eval("OgrFotograf")%></td>
                        <td><%# Eval("OgrBakiye")%></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"~/OgrenciSilme.aspx?OGRID="+Eval("OgrId") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">SİL </asp:HyperLink>
                            <asp:HyperLink  NavigateUrl='<%#"~/OgrenciGüncelle.aspx?OGRID="+Eval("OgrId") %>' ID="HyperLink2" runat="server" CssClass="btn btn-info">GÜNCELLE</asp:HyperLink>
                        </td>
                                              
                    </tr>
                      
                </ItemTemplate>
                
            </asp:Repeater>
         
        </tbody>

    </table>
     
</asp:Content>

