using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class EX06HtmlServerControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            buttonDangNhap.ServerClick += buttonDangNhap_ServerClick;
        }

        void buttonDangNhap_ServerClick(object sender, EventArgs e)
        {
           if(inputEmail.Value.Trim()=="hv@gmail.com" && inputPassword.Value.Trim()=="123")
           {
               divThongBao.InnerHtml = "Đăng nhập thành công.";
               divThongBao.Attributes.Add("class", "text-center text-success");
           }
            else
           {
               divThongBao.InnerHtml = "Đăng nhập thất bại.";
               divThongBao.Attributes.Add("class", "text-center text-danger");
           }
        }
    }
}