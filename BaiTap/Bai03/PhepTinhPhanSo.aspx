<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhepTinhPhanSo.aspx.cs" Inherits="BaiTap.Bai03.PhepTinhPhanSo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/Content/Site.css" rel="stylesheet" />
    <title>Phép tính trên phân số</title>
</head>
<body>
    <form id="form1" runat="server">
    <article class="main-Content">
        <h2>Phép tính trên phân số</h2>
        <table >
                <tr>
                    <td class="col1">Phân số 1</td>
                    <td>
                        <asp:TextBox ID="txtPhanSo1" runat="server" Width="99.8%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Phân số 2</td>
                    <td>
                        <asp:TextBox ID="txtPhanSo2" runat="server" Width="99.8%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblKetQua" runat="server" Text="Kết quả"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtKetQua" runat="server" ReadOnly="True" Width="99.8%" BackColor="#C4C4FF"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-right" colspan="2">
                        <asp:ImageButton ID="btnCong" runat="server" ImageUrl="~/Images/math_plus_red.png" OnClick="btnCong_Click" />
&nbsp;<asp:ImageButton ID="btnTru" runat="server" ImageUrl="~/Images/math_minus_red.png" OnClick="btnTru_Click" />
&nbsp;<asp:ImageButton ID="btnNhan" runat="server" ImageUrl="~/Images/math_multiply_red.png" OnClick="btnNhan_Click" />
&nbsp;<asp:ImageButton ID="btnChia" runat="server" ImageUrl="~/Images/math_divide_red.png" OnClick="btnChia_Click" />
&nbsp;<asp:ImageButton ID="btnXoaNoiDung" runat="server" ImageUrl="~/Images/math_clear_red.png" OnClick="btnXoaNoiDung_Click" /><br />
                        <asp:Label ID="lblBaoLoi" runat="server" Width="100%" ForeColor="Red" ViewStateMode="Disabled"></asp:Label>
                    </td>
                </tr>
            </table>
    </article>
    </form>
</body>
</html>
