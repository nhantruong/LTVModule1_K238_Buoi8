using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai03
{
    public partial class WFDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1- Khai báo một biến đối tượng nv1 kiểu NhanVien
            NhanVien nv1;

            // 2- Khởi tạo biến đối tượng nv1 kiểu NhanVien
            nv1 = new NhanVien();
            // 3- Gán|Set giá trị cho thuộc tính dữ liệu của biến
            nv1.MaSo = "A01";
            nv1.GioiTinh = Phai.Nam;

            // -- Đọc|Get giá trị của thuộc tính
            string m1 = nv1.MaSo;


            DateTime ns=new DateTime(1986,1,25);
            DateTime nvl=DateTime.Parse("1/15/2015");
            NhanVien nv2 = new NhanVien("A02","TVB",ns,nvl,Phai.Nam,1.5);

            NhanVien nv3;
            


        }

        protected void buttonGhiThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                // Khai báo và khởi tạo biến đối tượng nv kiểu NhanVien
                NhanVien nv = new NhanVien();
                nv.MaSo = textBoxMaSo.Text;
                double hsl;
                if (double.TryParse(textBoxHeSoLuong.Text, out hsl) == false) throw new Exception("Hệ số lương phải nhập số");
                nv.HeSoLuong = hsl;
                nv.NgayVaoLam = DateTime.Parse(textBoxNgayVaoLam.Text);
                int tn = nv.ThamNien;
                double tl = nv.TinhLuong();
                labelThongBao.Text = string.Format("Ghi thành công.{0}Thâm niên:{1} năm{0}Tiền lương:{2}","<br/>",tn,tl.ToString("#,##0.0"));
            }           
            catch(Exception ex)
            {
                labelThongBao.Text = ex.Message;
            }
        }
    }
}