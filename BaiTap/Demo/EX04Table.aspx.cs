using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class EX04Table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int soA = int.Parse(textBoxSoA.Text);
                int soB = int.Parse(textBoxSoB.Text);

                int ketQua = soA + soB;

                textBoxKetQua.Text = ketQua.ToString();
            }
            catch(FormatException ex)
            {
                labelBaoLoi.Text = "Số A, Số B phải nhập số nguyên";
            }
            catch(Exception ex)
            {
                labelBaoLoi.Text = ex.Message;
            }

        }

        protected void buttonTiepTuc_Click(object sender, EventArgs e)
        {
            // Xóa nội dung các TextBox
            textBoxSoA.Text = "";
            textBoxSoB.Text = "";
            textBoxKetQua.Text = "";
            // Chuyển con trỏ vào textBoxSoA
            textBoxSoA.Focus();

        }
    }
}