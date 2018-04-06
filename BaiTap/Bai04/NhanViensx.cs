using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.Bai04
{
   public class NhanViensx:NhanVien
    {

       #region properties
        int _SoSanPham = 0;
        public int SoSanPham
        {
            get { return _SoSanPham; }
            set { _SoSanPham = value; }
        }
        static int _DinhMucSanPham = 312;   
        public static int DinhMucSanPham
        {
            get { return _DinhMucSanPham; }
            set { _DinhMucSanPham = value; }
        }
        static double _DonGiaSanPham = 10000;
        public static double DonGiaSanPham
        {
            get { return _DonGiaSanPham; }
            set { _DonGiaSanPham = value; }
        }

        static int _DinhMucVang;
        public static int DinhMucVang
        {
            get { return _DinhMucVang; }
            set { _DinhMucVang = value; }
        }

        #endregion
       #region Constructors
        public NhanViensx() 
        { 
             _DinhMucVang = NhanVien._DinhMucVang + 2;
            //NhanViensx._DinhMucVang = NhanVien._DinhMucVang + 2;

        } 
        public NhanViensx(string Maso, string HoTen, DateTime NgaySinh, DateTime NgayVaoLam, Phai GioiTinh, int SoNgayVang, int SoSanPham)
            : base(Maso, HoTen, NgaySinh, NgayVaoLam, GioiTinh, 1, SoNgayVang)
        {
            
            _DinhMucVang = NhanVien._DinhMucVang + 2;
            this.SoSanPham = SoSanPham;
        }
        
       #endregion 
       #region Method
        public override double TinhThuong()
        {
            double tienThuong = 0;
            if (_SoSanPham > _DinhMucSanPham)
                tienThuong = (_SoSanPham - _DinhMucSanPham) * _DonGiaSanPham*1.05;
            if (SoNgayVang > DinhMucVang)
            {
                int soNgayVDM = (_SoNgayVang - _DinhMucVang);
                double tienPhat=(_DinhMucSanPham/26) * (0.1*_DonGiaSanPham);
                tienThuong = tienThuong - (soNgayVDM * tienPhat);
            }
            return tienThuong;
        }
        public override double TinhLuong()
        {
            return _SoSanPham*_DonGiaSanPham + TinhThuong();
        }

        public override string XuatThongTin(string XuongDong = "<br/>")
        {
            double thuong = TinhThuong();
            double luong = TinhLuong();
            
            return string.Format("Nhân viên {1}-{2}{0}Loại nhân viên: Sản xuất{0}Tiền thưởng: {3}{0}Tiền lương: {4}",
                                    XuongDong,MaSo, HoTen, thuong.ToString("#,##0.00"), luong.ToString("#,##0.00"));
        }
       #endregion
    }
}
