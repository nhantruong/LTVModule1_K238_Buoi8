using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai05
{
    public class HinhChuNhat:IHinh,IComparable
    {

        #region
        private double _ChieuDai;

        public double ChieuDai
        {
            get { return _ChieuDai; }
            set { _ChieuDai = value; }
        }

        private double _ChieuRong;

        public double ChieuRong
        {
            get { return _ChieuRong; }
            set { _ChieuRong = value; }
        }
        //---------------------------------------------------------        
        public string TenHinh
        {
            get { return "Hình chữ nhật"; }
        }

        public double DienTich()
        {
            double kq = 0;
            kq = _ChieuDai * _ChieuRong;
            return kq;
        }

        public double ChuVi()
        {
            double kq = 0;
            kq = (_ChieuDai + _ChieuRong)*2;
            return kq;
        }
              

        public string XuatThongTin(string XuongDong = "\r\n")
        {
            string kq = "";
            kq = string.Format("{1}{0}Chiều dài:{2}{0}Chiều rộng:{3}{0}Diện tích:{4}{0}Chu vi:{5}{0}",
                                XuongDong, TenHinh, _ChieuDai, _ChieuRong, DienTich(), ChuVi());
            return kq;
        }

        #endregion
        
        public int CompareTo(object obj)
        {
            HinhChuNhat hcnSS = (HinhChuNhat)obj;
            double dt = this.DienTich();
            double dtSS = hcnSS.DienTich();
            int kqSS = dt.CompareTo(dtSS);
            return kqSS;
        }
    }
}