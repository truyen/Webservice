<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormDonHang.aspx.cs" Inherits="CuaHangDTDD.Admin.WebFormDonHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID="ListViewDonHang" runat="server">
        <LayoutTemplate>
            <table border="1">
                <tr>
                    <th>Mã Đơn Hàng</th>
                    <th>Ngày lập</th>
                    <th>Tổng Tiền</th>
                    <th>Đã Giao Hàng</th>
                    <th>Tên Khách Hàng</th>
                    <th>Địa Chỉ</th>
                    <th>Email</th>
                    <th>Số Điện Thoại</th>
                    <th>Tùy chọn</th>
                </tr>
                <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Eval("id") %></td>
                <td><%# Eval("ngay") %></td>
                <td><%# Eval("tongtien") %></td>
                <td><%# Eval("dagiaohang") %></td>
                <td><%# Eval("kh_ten") %></td>
                <td><%# Eval("kh_diachi") %></td>
                <td><%# Eval("kh_email") %></td>
                <td><%# Eval("kh_sdt") %></td>
           </tr>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
