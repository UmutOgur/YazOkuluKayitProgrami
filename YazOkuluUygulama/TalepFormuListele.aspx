<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TalepFormuListele.aspx.cs" Inherits="TalepFormuListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <table class="table table-bordered table-hover">
        <tr>
            <th>BAŞVURU İD</th>
            <th>ÖĞRENCİ İD</th>
            <th>DERS İD</th>

        </tr>
        <tbody>

            <asp:repeater ID="Reapeter2" runat="server">
                <ItemTemplate>
            <tr>
                <td><%# Eval("BASVURUID")%></td>
                <td><%# Eval("BASOGRID")%></td>
                <td><%# Eval("BASDERSİD")%></td>
                
            </tr>

                </ItemTemplate>
            </asp:repeater>

        </tbody>


    </table>

</asp:Content>

