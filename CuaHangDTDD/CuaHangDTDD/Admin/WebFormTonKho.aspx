<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormTonKho.aspx.cs" Inherits="CuaHangDTDD.Admin.WebFormTonKho" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID="ListViewTonKho" runat="server">
        <LayoutTemplate>
            <table border="1">
                <tr>
                    <th>ID</th>
                    <th>Số lượng</th>
                    <th>Ngày</th>
                    <th>Tùy chọn</th>
                </tr>
                <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Eval("id") %></td>
                <td><%# Eval("soluong") %></td>
                <td><%# Eval("ngay") %></td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
