using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai04
{
    public partial class WFDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime ns = new DateTime(1986, 1, 25);
            DateTime nvl = DateTime.Parse("1/15/2015");

            NhanVienvp nv1 = new NhanVienvp("K01", "NVA", ns, nvl, Phai.Nam, 1.5, 5);

            labelThongTin.Text = nv1.XuatThongTin();

            textBoxThongTin.Text = nv1.XuatThongTin("\r\n");
        }
    }
}