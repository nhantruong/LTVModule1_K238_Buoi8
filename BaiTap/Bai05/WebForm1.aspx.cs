using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai05
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         

        }

        protected void buttonHinhVuong_Click(object sender, EventArgs e)
        {
            HinhVuong hv = new HinhVuong();
            hv.Canh = 5000;
            textBoxKetQua.Text = hv.XuatThongTin();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] MangSo = new int[] { 5,3,4,1};
            Array.Sort(MangSo);

            HinhChuNhat[] mangHCN= new HinhChuNhat[3];
            mangHCN[0] = new HinhChuNhat { ChieuDai = 10, ChieuRong = 5 };
            mangHCN[1] = new HinhChuNhat { ChieuDai = 30, ChieuRong = 5 };
            mangHCN[2] = new HinhChuNhat { ChieuDai = 20, ChieuRong = 5 };
            Array.Sort(mangHCN);

        }
    }
}