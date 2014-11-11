<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormHangSX.aspx.cs" Inherits="CuaHangDTDD.Admin.WebFormHangSX" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="title">Quản Lý Hãng Sản Xuất</div>
    <asp:ListView ID="ListViewHangSX" runat="server">
        <LayoutTemplate>
            
            <table border="1" style="border-collapse:collapse ; ">
                <tr>
                    <td>
                        <asp:Button ID="btnThem" runat="server" CssClass="btnthem" Text="Thêm mới" OnClick="btnThem_Click"/> 
                    </td>
                </tr>
                <tr>
                    <th>Mã Hãng SX</th>
                    <th>Tên Hãng SX</th>
                    <th>Active</th>
                    <th>Tùy chọn</th>
                </tr>
                <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Eval("id") %></td>
                <td><%# Eval("ten") %></td>
                <td><%# Eval("active") %></td>
                <td>
                   
                    <asp:HiddenField ID="HiddenFieldid" Value='<%# Eval("id") %>' runat="server" />
                    <asp:LinkButton ID="LinkButtonXoa" runat="server" OnClientClick="return confirm('Bạn có chắc không?')" OnClick="LinkButtonXoa_Click">Xóa</asp:LinkButton> ||
                    <asp:LinkButton ID="LinkButtonSua" runat="server" OnClick="LinkButtonSua_Click">Cập Nhật</asp:LinkButton>
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
    <asp:Label ID="LabelThongBao" runat="server" Text=""></asp:Label>
    <asp:Panel ID="pnUpdate" runat="server">
        <table id="table2" style="border-collapse:collapse;" cellpadding="0" width="100%" border="0">
            <tr>
                <td width="150" class="name_fild_row">
                    <asp:Label ID="Label1" Text="Tên Hãng SX" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" /><asp:TextBox ID="txtId" runat="server" Visible="false"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="150" class="name_fild_row">
                    <asp:Label ID="Label4" Text="Trạng thái" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="txtStatus" runat="server" />
                </td>
            </tr>
                <td width="150" class="name_fild_row">
                </td>
                <td>
                    <asp:LinkButton ID="lbtUpdate" CssClass="update" runat="server" 
                        onclick="lbtUpdate_Click">Lưu</asp:LinkButton>
                    <asp:LinkButton ID="lbtBack" CssClass="back" runat="server" 
                        onclick="lbtBack_Click">Trở lại</asp:LinkButton>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
