using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai03
{
    public partial class PhepTinhPhanSo_NangCao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //PhanSo p1 = new PhanSo(1, 2);
            //PhanSo p2 = new PhanSo(1, 4);
            //PhanSo kq = p1 + p2;
            //PhanSo pA = new PhanSo(2, 4);
            //PhanSo pB = new PhanSo(4, 8);
            //bool kqSS1 = pA != pB;
            //bool kqSS2 = pA == pB;
        }

        protected void btnCong_Click(object sender, ImageClickEventArgs e)
        {
            try
            { 
                PhanSo p1,p2,kq;
                if (!PhanSo.TryParse(txtPhanSo1.Text, out p1)) throw new Exception("Phân số 1 không hợp lệ");
                if (!PhanSo.TryParse(txtPhanSo2.Text, out p2)) throw new Exception("Phân số 2 không hợp lệ");
                kq = p1 + p2;
                txtKetQua.Text = kq.Xuat();
            }
            catch(Exception ex)
            {
                lblBaoLoi.Text ="Báo lổi:"+ ex.Message;
            }
            
        }

        protected void btnTru_Click(object sender, ImageClickEventArgs e)
        {
           
        }

        protected void btnSoSanh_Click(object sender, ImageClickEventArgs e)
        {
            PhanSo p1, p2;
            if (!PhanSo.TryParse(txtPhanSo1.Text, out p1)) throw new Exception("Phân số 1 không hợp lệ");
            if (!PhanSo.TryParse(txtPhanSo2.Text, out p2)) throw new Exception("Phân số 2 không hợp lệ");
            bool kq = p1 == p2;

            if (kq == true)
                txtKetQua.Text = "Hai phân số bằng nhau";
            else
                txtKetQua.Text = "Hai phân số không bằng nhau";
                
        }

        protected void btnXoaNoiDung_Click(object sender, ImageClickEventArgs e)
        {
            txtPhanSo1.Text = "";
            txtPhanSo2.Text = "";
            txtKetQua.Text = "";
            lblKetQua.Text = "Kết quả";
            txtPhanSo1.Focus();
        }

       

      
    }
}