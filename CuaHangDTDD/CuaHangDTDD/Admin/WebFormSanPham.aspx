<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormSanPham.aspx.cs" Inherits="CuaHangDTDD.Admin.WebFormSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID="ListViewSanPham" runat="server">
        <LayoutTemplate>
            <table border="1">
                <tr>
                    <th>Mã Sản Phẩm</th>
                    <th>Tên Sản Phẩm</th>
                    <th>Mô tả</th>
                    <th>Giá</th>
                    <th>Hãng Sản Xuất</th>
                    <th>Tùy chọn</th>
                </tr>
                <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Eval("masp") %></td>
                <td><%# Eval("ten") %></td>
                <td><%# Eval("mota") %></td>
                <td><%# Eval("gia") %></td>
                <td><%# Eval("hangsx_id") %></td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
