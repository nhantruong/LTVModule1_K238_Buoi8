using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.DemoOOP
{
    // Bước 1:
    // Định nghĩa một delegate tên là PhepTinh,
    // dùng để tham chiếu đến các phương thức có cùng cách thức khai báo giống nó.
    public delegate int PhepTinh(int x,int y);   

    public partial class EXDelegate : System.Web.UI.Page
    {
        #region Bước 2
            // Xây dựng các phương thức có cùng cách thức khai báo với delegate PhepTinh
        private int TinhTong(int a,int b)
        {
            return a + b;
        }
        private int TinhTich(int m, int n)
        {
            return m * n;
        }
        #endregion
        #region Bước 3
            // Sử dụng delegate để tham chiếu đến phương thức có cùng cách thức khai báo với nó 
            // và gọi thực thi phương thức đó
        protected void buttonTong_Click(object sender, EventArgs e)
        {
            // Khai báo biến đối tượng tên p kiểu delegate PhepTinh
            PhepTinh p;
            // Khởi tạo p tham chiếu đến phương thức TinhTong
            p = new PhepTinh(TinhTong);
            // Gọi delegate p thực thi
            int kqTong1 = p.Invoke(2, 5);
            int kqTong2 = p(3, 4);
        }
        protected void buttonTich_Click(object sender, EventArgs e)
        {
            // Khai báo biến p kiểu delegate PhepTinh
            PhepTinh p;
            // Khởi tạo p tham chiếu đến phương thức TinhTich
            p = new PhepTinh(TinhTich);
            // Gọi delegate p thực thi
            int kqTich1 = p.Invoke(2, 5);
            int kqTich2 = p(3, 4);
        }


        #endregion

        protected void buttonMR1_Click(object sender, EventArgs e)
        {
            PhepTinh p = (a, b) => a - b;
            int kq = p(7, 5);
            labelKetQua.Text = kq.ToString();
        }

        protected void buttonMR2_Click(object sender, EventArgs e)
        {
            PhepTinh tinhTienBanHang = (soLuong, donGia) =>
            {
                int kq = soLuong * donGia;
                if (kq >= 1000000) kq -= 100000;
                return kq;
            };
            int soTien = tinhTienBanHang(10, 100000);
            labelKetQua.Text = soTien.ToString();

        }

    }
}