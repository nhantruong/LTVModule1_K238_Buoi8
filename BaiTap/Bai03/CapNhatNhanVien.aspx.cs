using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai03
{
    public partial class CapNhatNhanVien : System.Web.UI.Page
    {
       
        protected void btnXuatThongTin_Click(object sender, EventArgs e)
        {
            try
            { 
               //1- Khai báo & khởi tạo biến đối tượng nv kiểu NhanVien

               //2- Gán giá trị cho các thuộc tính của nv
 
               //3- Gọi phương thức Xuất thông của đối tượng nv

               //4-Kết xuất: xuất thông tin của đối tượng lên label
 
               //5-Chuyển sang view 2
                MultiView1.ActiveViewIndex = 1;

            }
            catch(FormatException ex)
            {
                lblBaoLoi.Text = "Dữ liệu nhập không hợp lệ.";
            }
            catch(Exception ex)
            {
                lblBaoLoi.Text = ex.Message;
            }
        }

        protected void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtMaso.Text = "";
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            txtNgayVaoLam.Text = "";
            txtHeSoLuong.Text = "";
            chkGioiTinh.Checked = false;
           
            txtMaso.Focus();
            MultiView1.ActiveViewIndex = 0;
        }
    }
}