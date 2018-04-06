<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhepTinhPhanSo_NangCao.aspx.cs" Inherits="BaiTap.Bai03.PhepTinhPhanSo_NangCao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/Content/Site.css" rel="stylesheet" />
    <title>Phép tính trên phân số (nâng cao)</title>
</head>
<body>
    <form id="form1" runat="server">
    <article class="main-Content">
        <h2>Phép tính trên phân số (nâng cao)</h2>
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
                        <asp:ImageButton ID="btnCong" runat="server" ImageUrl="~/Images/math_plus_blue-jelly.png" OnClick="btnCong_Click" Height="32px" />
&nbsp;<asp:ImageButton ID="btnTru" runat="server" ImageUrl="~/Images/math_minus_blue-jelly.png" OnClick="btnTru_Click" Height="30px" />
&nbsp;<asp:ImageButton ID="btnSoSanh" runat="server" ImageUrl="~/Images/question-mark-icon_32.png" OnClick="btnSoSanh_Click" />
&nbsp;&nbsp;<asp:ImageButton ID="btnXoaNoiDung" runat="server" ImageUrl="~/Images/undo-arrow_blue.png" OnClick="btnXoaNoiDung_Click" Height="28px" />
                                            <asp:Label ID="lblBaoLoi" runat="server" Width="100%" ForeColor="Red" ViewStateMode="Disabled"></asp:Label>

                    </td>
                </tr>
            </table>
    </article>
    </form>
</body>
</html>
