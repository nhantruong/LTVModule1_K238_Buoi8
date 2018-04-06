<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TinhDienTichHCN.aspx.cs" Inherits="BaiTap.Bai05.TinhDienTichHCN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính diện tích  Hình chữ nhật</title>
    <link href="~/Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="main-Content">
            <h2>Tính diện tích hình chữ nhật</h2>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Chiều dài" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtChieuDai" runat="server" CssClass="form-control">20</asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Chiều rộng" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtChieuRong" runat="server" CssClass="form-control">5</asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Diện tích" CssClass="col-left control-label"></asp:Label>
               
                <div class="col-right">
                    <asp:TextBox ID="txtDienTich" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                </div>
            </div>
            <div class="text-right" style="padding-right: 40px">
                <asp:Button ID="btnTinh" runat="server" Text=" Tính " OnClick="btnTinh_Click" />
                <asp:Button ID="btnTiep" runat="server" Text=" Tiếp " OnClick="btnTiep_Click" />
            </div>
        </div>
    </form>
</body>
</html>
