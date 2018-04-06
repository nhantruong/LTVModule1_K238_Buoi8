<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EX04Table.aspx.cs" Inherits="BaiTap.Demo.EX04Table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 500px;
            border: 1px solid #009900;
            margin:100px auto;
        }
        .canh-giua{text-align:center;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="6" cellspacing="0" class="auto-style1">
            <tr>
                <td colspan="2" style="font-size: 1.8em; font-weight: bold; color: #FFFFFF; background-color: #FF6600; padding: 15px; text-align: center">Tính tổng hai số nguyên</td>
            </tr>
            <tr>
                <td style="width:30%">Số A</td>
                <td>
                    <asp:TextBox ID="textBoxSoA" runat="server" Width="98%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Số B</td>
                <td>
                    <asp:TextBox ID="textBoxSoB" runat="server" Width="98%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Kết quả</td>
                <td>
                    <asp:TextBox ID="textBoxKetQua" runat="server" ReadOnly="True" Width="98%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="buttonTinh" runat="server" Text="Tính" OnClick="buttonTinh_Click" />
&nbsp;<asp:Button ID="buttonTiepTuc" runat="server" Text="Tiếp tục" OnClick="buttonTiepTuc_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="labelBaoLoi" runat="server" ForeColor="#CC0000" Width="100%" CssClass="canh-giua"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
