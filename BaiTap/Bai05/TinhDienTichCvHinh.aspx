<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TinhDienTichCvHinh.aspx.cs" Inherits="BaiTap.Bai05.TinhDienTichCvHinh" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính diện tích & chu vi (Hình)</title>
    <link href="~/Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="main-Content">
     <h2>Tính diện tích & chu vi</h2>
        <div class="form-group">
                <asp:Label ID="lblLoaiMay" runat="server" Text="Chọn hình" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <div class="form-control">
                    <asp:RadioButton ID="rdbHinhVuong" runat="server" GroupName="ChonHinh"  Text="Hình vuông" AutoPostBack="True" OnCheckedChanged="rdbHinhVuong_CheckedChanged" />
                    &nbsp;
                    <asp:RadioButton ID="rdbHinhChuNhat" runat="server" GroupName="ChonHinh" Text="Hình chữ nhật" AutoPostBack="True" Checked="True" OnCheckedChanged="rdbHinhChuNhat_CheckedChanged" />
                    </div>
                </div>
            </div>
              <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="1">
                  <asp:View ID="View1" runat="server">
           <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Cạnh" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtCanh" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
                      </asp:View>
                   <asp:View ID="View2" runat="server">
                        <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Chiều dài" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtChieuDai" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Chiều rộng" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtChieuRong" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
                       </asp:View>
                  </asp:MultiView>
           <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Kết quả" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtKetQua" runat="server" CssClass="form-control" ReadOnly="true" Height="100px" Rows="4" TextMode="MultiLine"></asp:TextBox>
                </div>
            </div>
             <div class="text-right" style="padding-right:40px">
                   <asp:Button ID="btnTinh" runat="server" Text=" Tính " OnClick="btnTinh_Click"  />
                 <asp:Button ID="btnTiep" runat="server" Text=" Tiếp " OnClick="btnTiep_Click"  />
             </div>
    </div>
    </form>
</body>
</html>
