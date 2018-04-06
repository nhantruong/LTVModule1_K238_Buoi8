using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai05
{
    public class HinhVuong:IHinh
    {

        public double Canh { get; set; }
        
        //---------

        public string TenHinh
        {
            get {  return "Hình Vuông";  }
        }
        public double DienTich()
        {
            double kq = 0;
            //kq = Canh * Canh;
            kq = Math.Pow(Canh, 2);
            return kq;
        }
        public double ChuVi()
        {
            double kq = 0;
            kq = Canh * 4;
            return kq;
        }

        public string XuatThongTin(string XuongDong = "\r\n")
        {
            string kq = "";
            char c = (char)178;
            
            string dienTich=DienTich().ToString("#,##0m")+c.ToString();
            string chuVi=ChuVi().ToString("#,##0");
            kq = string.Format("{1}{0}Cạnh:{2}{0}Diện tích:{3}{0}Chu vi:{4}",XuongDong,TenHinh,Canh,dienTich,chuVi);
            return kq;
        }
    }
}