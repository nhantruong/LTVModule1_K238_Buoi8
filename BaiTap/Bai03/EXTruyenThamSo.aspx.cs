using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai03
{
    public partial class EXTruyenThamSo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double st1 = XuLySoLieu.TinhTien(2, 100);
            double st2 = XuLySoLieu.TinhTien(2, 100,15000);
            double st3 = XuLySoLieu.TinhTien(2, 100, 14000.0F);

            double t1 = XuLySoLieu.TinhTienBanHang(2,100);
            double t2 = XuLySoLieu.TinhTienBanHang(2, 100,15.500);
            double t3 = XuLySoLieu.TinhTienBanHang(2, 100, 15.500F);
        }
        #region
        //int soA = 2;
        //int soB = 3;
        //int kq1 = TinhTong2SoNguyen(soA, ref soB);

        //int n1 = 5;
        //int n2 = 7;
        //int tong = 0, tich = 0;
        //TinhTongTich2SoNguyen(n1, n2,ref tong,ref tich);

        //double d1 = 3.5;
        //double d2 = 5;
        //double kqTong, kqTich;
        //TinhTongTich2SoThuc(d1, d2, out kqTong, out kqTich);

        int TinhTong2SoNguyen(int a,ref int b)
        {
            a = a + 10; // Thay đổi giá trị của tham số hình thức
            b = b + 20; // Thay đổi giá trị của tham số hình thức

            int kq = a + b;
            return kq;
        }

        private void TinhTongTich2SoNguyen(int a,int b , ref int tong,ref int tich)
        {
            tong = a + b;
            tich = a * b;
        }
        private void TinhTongTich2SoThuc(double a, double b, out double tong, out double tich)
        {
            tong = a + b;
            tich = a * b;
        }
        #endregion
        private double TongDaySo(params double[] DaySo)
        {
            double kq = 0;
            foreach(double so in DaySo)
            {
                kq += so;
            }
            return kq;
        }
    }
}