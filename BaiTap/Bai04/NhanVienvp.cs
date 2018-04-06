using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai04
{
    public class NhanVienvp:NhanVien
    {
        private static double _DonGiaPhat=100000;

        public static double DonGiaPhat
        {
            get { return _DonGiaPhat; }
            set { _DonGiaPhat = value; }
        }
        public double TinhPhat()
        {
            double kq = 0;
            if(_SoNgayVang>_DinhMucVang)
            {
                kq = (_SoNgayVang - _DinhMucVang) * _DonGiaPhat;
            }
            return kq;
        }
        public NhanVienvp()
            :base(){ }
        
        public NhanVienvp(string MaSo,string HoTen, DateTime NgaySinh,DateTime NgayVaoLam, Phai GioiTinh, double HeSoLuong)
            :base(MaSo,HoTen,NgaySinh,NgayVaoLam,GioiTinh,HeSoLuong){ }

        public NhanVienvp(string MaSo, string HoTen, DateTime NgaySinh, DateTime NgayVaoLam, Phai GioiTinh, double HeSoLuong,int SoNgayVang)
            : base(MaSo, HoTen, NgaySinh, NgayVaoLam, GioiTinh, HeSoLuong,SoNgayVang) { }

        public override double TinhThuong()
        {
            double kq = 0;
            //kq = LuongCoBan * HeSoLuong * 0.1;
            kq = base.TinhLuong() * 0.1; // Gọi phương thức của class cha
            return kq;
        }

        public override double TinhLuong()
        {
            double kq = 0;
            kq = base.TinhLuong() + TinhThuong() - TinhPhat();
            return kq;
        }

        public override string XuatThongTin(string XuongDong = "<br/>")
        {
            string kq = "";
            string thuong = TinhThuong().ToString("#,##0VND");
            string phat = TinhPhat().ToString("#,##0VND");
            string luongnv = base.TinhLuong().ToString("#,##0VND");
            //string thuclanh = TinhLuong().ToString("#,##0VND");
            string thuclanh = this.TinhLuong().ToString("#,##0VND");

            kq = string.Format(@"Nhân viên {1}-{6}{0}Loại nhân viên: Văn phòng{0}Tiền thưởng:{2}{0}Tiền phạt:{3}{0}Tiền lương:{4}{0}Thực lãnh:{5}"                                                          
                        ,XuongDong,MaSo,thuong,phat,luongnv,thuclanh,HoTen);
            return kq;
        }

    }
}