using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai05
{
    public partial class TinhDienTichHCN : System.Web.UI.Page
    {
      
        protected void btnTinh_Click(object sender, EventArgs e)
        {
            double dai = double.Parse(txtChieuDai.Text);
            double rong = double.Parse(txtChieuRong.Text);

            HinhChuNhat h = new HinhChuNhat { ChieuDai = dai, ChieuRong = rong };
            double dt = h.DienTich();
            char sup2 = (char)178;
            txtDienTich.Text = dt.ToString("#,##0m")+sup2.ToString();
        }

        protected void btnTiep_Click(object sender, EventArgs e)
        {
            txtChieuDai.Text = "";
            txtChieuRong.Text = "";
            txtDienTich.Text = "";
            txtChieuDai.Focus();
        }
    }
}