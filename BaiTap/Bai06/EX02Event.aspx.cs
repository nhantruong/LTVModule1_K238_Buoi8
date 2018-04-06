using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai06
{
    public partial class EX02Event : System.Web.UI.Page
    {
        // Khai báo biến sử dụng cục bộ trong class
        private NhanVien2 nv;

        protected void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            // 1-Khởi tạo giá trị ban đầu cho đối tượng nv
            nv = new NhanVien2
            {
                MaSo = "NV01",
                HoTen = "Trần Thanh Tùng",
                GioiTinh = Phai.Nữ,
                NgaySinh = new DateTime(1985, 5, 15),
                NgayVaoLam = DateTime.Today
            };
            // 2-Khai báo sử dụng sự kiện TangLuong
            nv.TangLuong += nv_TangLuong;
            // 3- Lưu thông tin vào Session
            Session["ThongTinNhanVien"] = nv;

        }

        void nv_TangLuong(object sender, EventArgs e)
        {
            //string noiDung = sender.ToString();
            string noiDung = (string)sender;
            throw new NotImplementedException(noiDung);
        }

     

        protected void btnCapNhatHSL_Click(object sender, EventArgs e)
        {
            // Tham chiếu đến thông tin nhân viên lưu trong Session
            nv = Session["ThongTinNhanVien"] as NhanVien2;
            try
            {
                // Thay đổi hệ số lương
                nv.HeSoLuong = double.Parse(txtHSL.Text);
            }
            catch (NotImplementedException ex)
            {
                labelThongBao.Text = ex.Message;
                labelThongBao.ForeColor = Color.Green;
            }
            catch (FormatException ex)
            {
                labelThongBao.Text = "Hệ số lương phải là số thực";
                labelThongBao.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                labelThongBao.Text = ex.Message;
                labelThongBao.ForeColor = Color.Red;
            }
        }
    }
}