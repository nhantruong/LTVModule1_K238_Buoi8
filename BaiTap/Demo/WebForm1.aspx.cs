using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
      
        //protected void LinkButton1_Click(object sender, EventArgs e)
        //{
        //    literalBanDo.Text = "<iframe src='https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3296.0133245976617!2d106.6813190402201!3d10.762011435041657!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31752f1bfc262bf1%3A0x4e843897f2900135!2zMjI3IE5ndXnhu4VuIFbEg24gQ-G7qywgcGjGsOG7nW5nIDQsIEjhu5MgQ2jDrSBNaW5oLCBWaWV0bmFt!5e0!3m2!1sen!2s!4v1521343645681' width='400' height='300' frameborder='0' style='border:0' allowfullscreen></iframe>";

        //}

        //protected void LinkButton2_Click(object sender, EventArgs e)
        //{
        //    literalBanDo.Text = "<iframe src='https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3919.6757668549963!2d106.66466961524206!3d10.759452492333061!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31752ee20622ced1%3A0xbb9ce5971b969845!2zxJDDoG8gdOG6oW8gxJDhu5MgaOG7jWEgLSBUcnVuZyBUw6JtIFRpbiBI4buNYyAtIMSQSCBLaG9hIEjhu41jIFThu7EgTmhpw6puIFRQLkhDTQ!5e0!3m2!1sen!2s!4v1521344469870' width='400' height='300' frameborder='0' style='border:0' allowfullscreen></iframe>";
        //}

        protected void XulyLoadBanDo(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            switch(btn.ID)
            { 
                case "LinkButton1":
                    literalBanDo.Text = "<iframe src='https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3296.0133245976617!2d106.6813190402201!3d10.762011435041657!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31752f1bfc262bf1%3A0x4e843897f2900135!2zMjI3IE5ndXnhu4VuIFbEg24gQ-G7qywgcGjGsOG7nW5nIDQsIEjhu5MgQ2jDrSBNaW5oLCBWaWV0bmFt!5e0!3m2!1sen!2s!4v1521343645681' width='400' height='300' frameborder='0' style='border:0' allowfullscreen></iframe>";
                    break;
                case "LinkButton2":
                    literalBanDo.Text = "<iframe src='https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3919.6757668549963!2d106.66466961524206!3d10.759452492333061!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31752ee20622ced1%3A0xbb9ce5971b969845!2zxJDDoG8gdOG6oW8gxJDhu5MgaOG7jWEgLSBUcnVuZyBUw6JtIFRpbiBI4buNYyAtIMSQSCBLaG9hIEjhu41jIFThu7EgTmhpw6puIFRQLkhDTQ!5e0!3m2!1sen!2s!4v1521344469870' width='400' height='300' frameborder='0' style='border:0' allowfullscreen></iframe>";
                    break;
            };
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}