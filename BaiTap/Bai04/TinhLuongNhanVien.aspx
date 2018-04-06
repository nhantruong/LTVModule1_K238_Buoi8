<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TinhLuongNhanVien.aspx.cs" Inherits="BaiTap.Bai04.TinhLuongNhanVien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quản lý lương nhân viên</title>
    <link href="~/Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
          <div class="main-Content">
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            
            <h2>Nhập thông tin nhân viên</h2>
            <div class="form-group">
               
                <asp:Label ID="lblMaso" runat="server" Text="Mã số" CssClass="col-left control-label"></asp:Label>
               
                <div class="col-right">
                    <asp:TextBox ID="txtMaso" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                
                <asp:Label ID="lblHoTen" runat="server" Text="Họ tên" CssClass="col-left control-label"></asp:Label>
               
                <div class="col-right">
                    <asp:TextBox ID="txtHoTen" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
             <div class="form-group">
                <asp:Label ID="lblNgaySinh" runat="server" Text="Ngày sinh" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtNgaySinh" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
             <div class="form-group">
                
                <asp:Label ID="Label2" runat="server" Text="Ngày vào làm" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtNgayVaoLam" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
             <div class="form-group">
                
                <asp:Label ID="lblHeSoLuong" runat="server" Text="Hệ số lương" CssClass="col-left control-label"></asp:Label>
                
                <div class="col-right">
                    <asp:TextBox ID="txtHeSoLuong" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
             <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Giới tính" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:CheckBox ID="chkGioiTinh" runat="server" Text="Nam" CssClass="control-checkbox" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblSoNgayVang" runat="server" Text="Số ngày vắng" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtSoNgayVang" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblLoaiNhanVien" runat="server" Text="Loại nhân viên" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    
                    <asp:RadioButton ID="rdbNVVP" runat="server" GroupName="LoaiNhanVien" Text="Văn phòng" />
                    &nbsp;<asp:RadioButton ID="rdbNVSX" runat="server" Checked="True" GroupName="LoaiNhanVien" Text="Sản xuất" />
                    
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblSoSanPham" runat="server" Text="Số sản phẩm" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtSoSanPham" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
             <div class="text-right" style="padding-right:40px">
                   <asp:Button ID="btnXuatThongTin" runat="server" Text="Xuất thông tin lương" OnClick="btnXuatThongTin_Click" /> &nbsp;
             </div>
        
        </asp:View>
        <asp:View ID="View2" runat="server">
            <h2>Thông tin lương nhân viên</h2>
            
            <div style="padding:10px 20px;">
                
                <asp:Label ID="lblThongTin" runat="server" Width="100%" ></asp:Label>
                
                <p class="text-right" style="padding:20px 0px;border-top:1px solid #c9c4c4">
                <asp:Button ID="btnTiepTuc" runat="server" Text=" Tiếp tục " OnClick="btnTiepTuc_Click" />
                    </p>
            </div>
        </asp:View>
        </asp:MultiView>
              </div>
    </form>
</body>
</html>
