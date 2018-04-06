using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai05
{
    public partial class TinhDienTichCvHinh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTinh_Click(object sender, EventArgs e)
        {
            // Ứng dụng kỹ thuật Late Binding 
            IHinh h;
            if(rdbHinhVuong.Checked)
            {
                double c = double.Parse(txtCanh.Text);
                h = new HinhVuong { Canh = c };
            }
            else
            {
                double d = double.Parse(txtChieuDai.Text);
                double r = double.Parse(txtChieuRong.Text);
                h = new HinhChuNhat { ChieuDai = d, ChieuRong = r };
            }
            txtKetQua.Text = h.XuatThongTin();            
        }
        
        protected void btnTiep_Click(object sender, EventArgs e)
        {
            txtChieuRong.Text = "";
            txtChieuDai.Text="";
            txtCanh.Text = "";
            txtKetQua.Text = "";
        }

        protected void rdbHinhVuong_CheckedChanged(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
            txtKetQua.Text = "";
        }

        protected void rdbHinhChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
            txtKetQua.Text = "";
        }
    }
}