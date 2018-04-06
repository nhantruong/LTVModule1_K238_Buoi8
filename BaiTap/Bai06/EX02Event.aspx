<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EX02Event.aspx.cs" Inherits="BaiTap.Bai06.EX02Event" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
    
        <asp:Button ID="btnThemNhanVien" runat="server" Text="1-Thêm nhân viên mới" OnClick="btnThemNhanVien_Click" />
        <br />
        <br />
        <asp:TextBox ID="txtHSL" runat="server"></asp:TextBox>
        <asp:Button ID="btnCapNhatHSL" runat="server" Text="2-Cập nhật hệ số lương" OnClick="btnCapNhatHSL_Click" />
        <br />
        <br />
        <asp:Label ID="labelThongBao" runat="server" ViewStateMode="Disabled"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
