<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFDemo.aspx.cs" Inherits="BaiTap.Bai03.WFDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="textBoxMaSo" runat="server" Text="K01"></asp:TextBox>
        <asp:TextBox ID="textBoxHeSoLuong" runat="server" Text="1.5"></asp:TextBox>
        <asp:TextBox ID="textBoxNgayVaoLam" runat="server" Text="1/1/2015"></asp:TextBox>
        <asp:Button ID="buttonGhiThongTin" runat="server" OnClick="buttonGhiThongTin_Click" Text="Ghi thông tin" />
        <br />
        <asp:Label ID="labelThongBao" runat="server" ForeColor="#FF6600"></asp:Label>
    
    </div>
    </form>
</body>
</html>
