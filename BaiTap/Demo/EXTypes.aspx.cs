using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
namespace BaiTap.Demo
{
    public partial class EXTypes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int n1 = 2;
            int n2;

            n2 = n1;
            n1 = 5;
            // ?n2

            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2;
            
            sb1.Append("Xin chào ");
            sb2 = sb1;
            sb1.Append("bạn");
            // ?sb2

            string s1 = "Chào";
            string s2;
            s2 = s1;
            s1 = "Chào bạn";

            //?s2
        }
    }
}