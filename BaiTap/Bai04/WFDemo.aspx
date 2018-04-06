<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFDemo.aspx.cs" Inherits="BaiTap.Bai04.WFDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="labelThongTin" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="textBoxThongTin" runat="server" Rows="4" TextMode="MultiLine" Width="300px" spellcheck="false"></asp:TextBox>
    </div>
        
    </form>
</body>
</html>
