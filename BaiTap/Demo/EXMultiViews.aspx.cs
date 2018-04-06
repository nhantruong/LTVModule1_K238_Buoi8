using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class EXMultiViews : System.Web.UI.Page
    {
       
        protected void imageButton1_Click(object sender, ImageClickEventArgs e)
        {
            // Chuyển sang view 1
            MultiView1.ActiveViewIndex = 0;
            // MultiView1.SetActiveView(View1);
        }

        protected void imageButton2_Click(object sender, ImageClickEventArgs e)
        {
            // Chuyển sang view 2
            MultiView1.ActiveViewIndex = 1;
            // MultiView1.SetActiveView(View2);
        }

        protected void button1_Click(object sender, EventArgs e)
        {

        }
    }
}