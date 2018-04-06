<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KhachHang.aspx.cs" Inherits="BaiTap.Bai02.KhachHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>2.3-Khách hàng</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <h2 class="page-header text-primary">Đăng ký - Thông tin khách hàng</h2>
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="col-sm-3 control-label">Tên đăng nhập</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="textBoxTenDangNhap" runat="server" CssClass="form-control" placeholder="Nhập vào đây tên đăng nhập"></asp:TextBox>
                    </div>
                </div>
                 <div class="form-group">
                    <label class="col-sm-3 control-label">Mật khẩu</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="textBoxMatKhau" runat="server" CssClass="form-control" placeholder="Nhập vào đây mật khẩu" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
                 <div class="form-group">
                    <label class="col-sm-3 control-label">Họ tên</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="textBoxHoTen" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div>
                 <div class="form-group">
                    <label class="col-sm-3 control-label">Email</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="textBoxEmail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                    </div>
                </div>
                 <div class="form-group">
                    <label class="col-sm-3 control-label">Địa chỉ</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="textBoxDiaChi" runat="server" CssClass="form-control" Rows="5" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>
                 <div class="form-group">
                    <label class="col-sm-3 control-label">Giới tính</label>
                    <div class="col-sm-9">
                        <asp:RadioButton ID="radioButtonNam" runat="server" Checked="True" GroupName="GroupGioiTinh" Text="Nam" />
                        <asp:RadioButton ID="radioButtonNu" runat="server" GroupName="GroupGioiTinh" Text="Nữ" />
                    </div>
                </div>
                 <div class="form-group">
                    <label class="col-sm-3 control-label">Ngày sinh</label>
                    <div class="col-sm-9">
                        <asp:DropDownList ID="dropDownListNgay" runat="server"></asp:DropDownList>
                        <asp:DropDownList ID="dropDownListThang" runat="server">
                            <asp:ListItem Value="1">Tháng Giêng</asp:ListItem>
                            <asp:ListItem Value="2">Tháng Hai</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="dropDownListNam" runat="server"></asp:DropDownList>
                    </div>
                </div>
                 <div class="form-group">
                    <label class="col-sm-3 control-label">Sở thích</label>
                    <div class="col-sm-9">
                        <asp:Panel ID="panelSoThich" runat="server">
                            <asp:CheckBox ID="CheckBox1" runat="server" Text="Xem phim" />
                            <asp:CheckBox ID="CheckBox2" runat="server" Text="Du Lịch" />
                            <asp:CheckBox ID="CheckBox3" runat="server" Text="Mua sắm"/>
                            <asp:CheckBox ID="CheckBox4" runat="server" Text="Chơi Game"/>
                            <asp:CheckBox ID="CheckBox5" runat="server" Text="Đọc truyện"/>
                            <asp:CheckBox ID="CheckBox6" runat="server" Text="Xem Tivi"/>
                        </asp:Panel>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-3 col-sm-9">
                        <asp:Button ID="buttonDangKy" runat="server" Text="Đăng ký" CssClass="btn btn-success" OnClick="buttonDangKy_Click" />
                         <asp:Label ID="labelThongTin" runat="server" CssClass="text-success" Width="100%" ViewStateMode="Disabled"></asp:Label>
                        <asp:Label ID="labelBaoLoi" runat="server" CssClass="text-danger" Width="100%" ViewStateMode="Disabled"></asp:Label>
                    </div>
                </div>
            </div>
           
        </div>

    </form>
</body>
</html>
