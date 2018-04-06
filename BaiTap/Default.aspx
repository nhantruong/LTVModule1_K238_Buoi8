<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BaiTap.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Module 1 - Thực hành</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <h2>Trang chủ</h2>
            <ol>
                <li>
                    <asp:HyperLink ID="hplChao" runat="server" NavigateUrl="~/Demo/EX01Chao.aspx" Target="_blank">Chào</asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="https://www.w3schools.com/">W3Schools</asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="HyperLink3" runat="server" ImageHeight="60px" ImageUrl="~/Images/hinhTT1.jpg" ImageWidth="100px" NavigateUrl="https://thethao.vnexpress.net/tin-tuc/giai-ngoai-hang-anh/salah-ghi-bon-ban-liverpool-thoi-lua-vao-gay-man-utd-3724319.html" Target="_blank" ToolTip="Salah ghi bốn bàn, Liverpool 'thổi lửa vào gáy' Man Utd"></asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="hplKhachHang" runat="server"></asp:HyperLink>
                </li>
            </ol>
        </div>
    </form>
</body>
</html>
