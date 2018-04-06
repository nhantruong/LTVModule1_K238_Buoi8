using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai03
{
    public partial class PhepTinhPhanSo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void btnCong_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                PhanSo p1 = PhanSo.Parse(txtPhanSo1.Text);
                PhanSo p2 = PhanSo.Parse(txtPhanSo2.Text);
                PhanSo kq = p1.Cong(p2);
                txtKetQua.Text = kq.Xuat();
            }
            catch(Exception ex)
            {
                lblBaoLoi.Text = "Báo lổi:" + ex.Message;
            }
        }

        protected void btnTru_Click(object sender, ImageClickEventArgs e)
        {
          
        }

        protected void btnNhan_Click(object sender, ImageClickEventArgs e)
        {
           
        }

        protected void btnChia_Click(object sender, ImageClickEventArgs e)
        {
          
        }

        protected void btnXoaNoiDung_Click(object sender, ImageClickEventArgs e)
        {
            txtPhanSo1.Text = "";
            txtPhanSo2.Text = "";
            txtKetQua.Text = "";
            lblKetQua.Text = "Kết quả";
            txtPhanSo1.Focus();
        }
    }
}