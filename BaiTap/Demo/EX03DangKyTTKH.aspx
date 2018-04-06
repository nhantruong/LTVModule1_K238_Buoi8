<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EX03DangKyTTKH.aspx.cs" Inherits="BaiTap.Demo.EX03DangKyTTKH" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Đăng ký thông tin khách hàng</h2>
        <hr/>
        <asp:Label ID="labelHoTen" runat="server" Text="Họ tên khách hàng" ForeColor="#0033CC"></asp:Label>

    &nbsp;<asp:TextBox ID="textBoxHoTen" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="buttonDangKy" runat="server" Text="Đăng ký" OnClick="buttonDangKy_Click" />
        <br />
        <br />
        <asp:Label ID="labelThongBao" runat="server" ForeColor="#FF3300"></asp:Label>

    </form>
</body>
</html>
