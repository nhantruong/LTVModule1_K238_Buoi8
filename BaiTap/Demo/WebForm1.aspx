<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BaiTap.Demo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ol>
            <li>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="XulyLoadBanDo">Cơ sở 1</asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton ID="LinkButton2" runat="server" OnClick="XulyLoadBanDo">Cơ sở 2</asp:LinkButton>
            </li>
        </ol>
        <asp:Literal ID="literalBanDo" runat="server"></asp:Literal>
    </div>
        <p>
            &nbsp;</p>
        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" OnCheckedChanged="RadioButton1_CheckedChanged" />
    </form>
</body>
</html>
