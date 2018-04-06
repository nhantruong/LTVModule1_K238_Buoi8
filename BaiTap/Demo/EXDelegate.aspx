<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EXDelegate.aspx.cs" Inherits="BaiTap.DemoOOP.EXDelegate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="buttonTong" runat="server" Text="Tổng" OnClick="buttonTong_Click" />
        <asp:Button ID="buttonTich" runat="server" Text="Tích" OnClick="buttonTich_Click" />
        <br />
        <br />
        <asp:Label ID="labelKetQua" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Button ID="buttonMR1" runat="server" Text="Ví dụ - MR1" OnClick="buttonMR1_Click" />
&nbsp;<asp:Button ID="buttonMR2" runat="server" Text="Ví dụ - MR2" OnClick="buttonMR2_Click" />
    </div>
    </form>
</body>
</html>
