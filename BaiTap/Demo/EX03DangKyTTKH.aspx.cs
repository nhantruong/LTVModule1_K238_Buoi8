using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class EX03DangKyTTKH : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonDangKy_Click(object sender, EventArgs e)
        {// C#

            string noiDung = "Xin chào " + textBoxHoTen.Text + "! <br/>Thông tin của bạn đã được ghi nhận.";
            labelThongBao.Text = noiDung;

        }
    }
}