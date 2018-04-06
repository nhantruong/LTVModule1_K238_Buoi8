using BaiTap.Bai05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class EX_Interface_as : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HinhVuong hv = new HinhVuong { Canh = 5 };
            HinhChuNhat hcn = new HinhChuNhat { ChieuDai = 10, ChieuRong = 20 };

            IHinh h;

            //h = hv;
            //double dt1 = h.DienTich();
            //h = hcn;
            //double dt2 = h.DienTich();


            h = hv as IHinh;
            h = (IHinh)hv;

            IHoSoCaNhan hscn;
            hscn = hv as IHoSoCaNhan;
            hscn = (IHoSoCaNhan)hv ;



        }
    }
}