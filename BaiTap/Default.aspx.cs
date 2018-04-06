using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                hplKhachHang.NavigateUrl = "~/Bai02/KhachHang.aspx";
                hplKhachHang.Target = "_blank";
                hplKhachHang.Text = "Đăng ký thông tin khách hàng";
            }
        }
    }
}