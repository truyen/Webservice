<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormNhanViens.aspx.cs" Inherits="CuaHangDTDD.Admin.WebFormNhanViens" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="title">Quản Lý Nhân Viên</div>
    <asp:ListView ID="ListViewNhanVien" runat="server">
        <LayoutTemplate>
            <table border="1" style="border-collapse:collapse ; ">
                <tr>
                    <th>Mã Nhân Viên</th>
                    <th>Tên Nhân Viên</th>
                    <th>Quyền</th>
                    <th>Tùy chọn</th>
                </tr>
                <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Eval("id") %></td>
                <td><%# Eval("ten") %></td>
                <td><%# Eval("quyen") %></td>
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
                    <asp:Label ID="Label1" Text="Tên Nhân Viên" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" /><asp:TextBox ID="txtId" runat="server" Visible="false"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="150" class="name_fild_row">
                    <asp:Label ID="Label2" Text="Mật Khẩu" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="txtPass" runat="server" />
                </td>
            </tr>
            <tr>
                <td width="150" class="name_fild_row">
                    <asp:Label ID="Label4" Text="Quyền" runat="server" />
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
