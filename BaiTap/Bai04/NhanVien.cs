using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai04
{
    public enum Phai {Nữ,Nam };
    public class NhanVien
    {
        #region Auto-Implemented Properties
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public Phai GioiTinh { get; set; }
        #endregion

        #region Full properties


        private DateTime _NgaySinh;

        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        private DateTime _NgayVaoLam;

        public DateTime NgayVaoLam
        {
            get { return _NgayVaoLam; }
            set { _NgayVaoLam = value; }
        }

        private double _HeSoLuong=1; // Khai báo giá trị mặc định

        public double HeSoLuong
        {
            get { return _HeSoLuong; }
            set 
            {
                if (value < 1) throw new Exception("Hệ số lương phải >=1");
                _HeSoLuong = value; 
            }
        }
        #endregion
        
        #region Read Only Property
        /// <summary>
        /// Trả về số năm đã làm việc tại công ty
        /// </summary>
        public int ThamNien
        {
            get
            {
                int kq=0;
                int namHienHanh = DateTime.Today.Year;
                int namVaoLam = _NgayVaoLam.Year;
                kq = namHienHanh - namVaoLam;
                return kq;
            }
        }
        #endregion

        #region static property

        private static double _LuongCoBan=5000000;

        public static double LuongCoBan
        {
            get { return _LuongCoBan; }
            set { _LuongCoBan = value; }
        }
                
        #endregion

        #region Phương thức xử lý tính toán
        
        public virtual double TinhLuong() 
        {
            double kq = 0;
            kq = _HeSoLuong * _LuongCoBan;
            return kq;
        }
        public virtual double TinhThuong()
        {
            double kq = 0;
            kq = ThamNien*500000;
            return kq;
        }
        public virtual string XuatThongTin(string XuongDong = "<br/>")
        {
            string kq = "";
            double luong = TinhLuong();
            double thuong = TinhLuong();
            double tong = luong + thuong;
            kq = string.Format("Nhân viên:{1}-{2}{0}Tiền thưởng:{3}{0}Tiền lương:{4}{0}Tổng cộng:{5}",
                XuongDong, MaSo, HoTen, thuong.ToString("#,##0VNĐ"), luong.ToString("#,##0VNĐ"), tong.ToString("#,##0VNĐ"));
            return kq;
        }
        #endregion

        #region Constructors - phương thức khởi tạo

        public NhanVien(string MaSo,string HoTen, DateTime NgaySinh,DateTime NgayVaoLam, Phai GioiTinh, double HeSoLuong)
        {
            this.MaSo = MaSo;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.NgayVaoLam = NgayVaoLam;
            this.GioiTinh = GioiTinh;
            this.HeSoLuong = HeSoLuong;
        }

        public NhanVien()
        {
            // Gán giá trị mặc định
            _NgayVaoLam = DateTime.Today;
        }

        #endregion


        #region Bài 4 bổ sung thêm

        protected int _SoNgayVang;
        public int SoNgayVang
        {
            get  {  return _SoNgayVang;  }
            set { _SoNgayVang = value; }
        }
        protected static int _DinhMucVang = 3;

        public static int DinhMucVang
        {
            get { return _DinhMucVang;  }
            set { _DinhMucVang = value; }
        }

        public NhanVien(string MaSo, string HoTen, DateTime NgaySinh, DateTime NgayVaoLam, Phai GioiTinh, double HeSoLuong,int SoNgayVang)
        {
            this.MaSo = MaSo;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.NgaySinh = NgaySinh;
            this.NgayVaoLam = NgayVaoLam;
            this.GioiTinh = GioiTinh;
            this.HeSoLuong = HeSoLuong;
            this.SoNgayVang = SoNgayVang;
        }
        
        #endregion

    }

}