using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace BaiTap.Bai02
{
    public partial class KhachHang : System.Web.UI.Page
    {

        #region Phương thức liên kết với sự kiện
        protected void buttonDangKy_Click(object sender, EventArgs e)
        {
            //labelBaoLoi.Text = "";
            //labelThongTin.Text = "";
            string ngaySinhStr = string.Format("{0}/{1}/{2}", 
                                            dropDownListThang.SelectedValue,
                                            dropDownListNgay.SelectedValue,
                                            dropDownListNam.SelectedValue
                                            );

            DateTime ngaySinh;
            if(!DateTime.TryParse(ngaySinhStr,out ngaySinh))
            {
                labelBaoLoi.Text = "Ngày sinh không hợp lệ.";
                return; //Thoát ngang khỏi phương thức
            }
            string gioiTinh = radioButtonNam.Checked? "Nam" : "Nữ";
                    
            StringBuilder sb = new StringBuilder();
            foreach (Control ct in panelSoThich.Controls)
            {
                if (ct.GetType().Name == "CheckBox")
                {
                    CheckBox chk = (CheckBox)ct;
                    if (chk.Checked) sb.AppendFormat("{0},", chk.Text);
                }
            }
            string soThich = sb.ToString().TrimEnd(',');

            string noiDung = string.Format(@"Tên đăng nhập:{1}{0}
                                            Mật khẩu:{2}{0}
                                            Giới tính:{3}{0}Ngày sinh:{5}{0}Sở thích:{4}{0}",
                                            "<br/>",textBoxTenDangNhap.Text,textBoxMatKhau.Text,gioiTinh,
                                            soThich,ngaySinh.ToString("dd-MM-yyyy"));
            labelThongTin.Text = noiDung;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) //Nếu là lần load đầu tiên
            {
                TaoDanhSachNgay();
                TaoDanhSachNam();
                TaoDanhSachThang();
            }
        }
        #endregion
        #region Phương thức tự định nghĩa - Method
        private void TaoDanhSachNgay()
        {
            dropDownListNgay.Items.Add(new ListItem("Ngày", "ngay"));
            for(int i=1;i<=31;i++)
            {
                string ngayStr = i.ToString("00");
                dropDownListNgay.Items.Add(ngayStr); //pt2
            }
        }
        private void TaoDanhSachNam()
        {
            int namHienHanh = DateTime.Today.Year;
            dropDownListNam.Items.Add("Năm");
            for (int i = namHienHanh; i >=1970; i--)
            {
                string namStr = i.ToString();
                dropDownListNam.Items.Add(namStr); //pt2
            }
        }
        private void TaoDanhSachThang()
        {
            ListItem it = new ListItem("Tháng Ba", "3");
            dropDownListThang.Items.Add(it);
            
            dropDownListThang.Items.Add(new ListItem("Tháng Tư", "4"));
            dropDownListThang.Items.Add(new ListItem("Tháng Năm", "5"));
            dropDownListThang.Items.Add(new ListItem("Tháng Sáu", "6"));
            dropDownListThang.Items.Insert(0, new ListItem("Tháng","thang"));


        }

        #endregion

    }
}