<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BaiTap.Bai05.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Button ID="buttonHinhVuong" runat="server" OnClick="buttonHinhVuong_Click" Text="1-Hình vuông" />
        <br />
        <asp:TextBox ID="textBoxKetQua" runat="server" Rows="5" TextMode="MultiLine" Width="200px"  spellcheck="false"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
    
    </div>
    </form>
</body>
</html>
