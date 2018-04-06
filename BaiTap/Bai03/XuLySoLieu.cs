using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai03
{
    public class XuLySoLieu
    {
        public static double TinhTien(int SoLuong, int GiaBan,float TyGia=1)
        {
            double kq = 0;
            kq = SoLuong * GiaBan * TyGia;
            return kq;
        }
        /// <summary>
        /// Tính tiền bán hàng
        /// </summary>
        /// <param name="SoLuong">Số lượng bán là giá trị kiểu số nguyên</param>
        /// <param name="GiaBan">Giá bán </param>
        /// <returns>Số tiền phải thanh toán</returns>
        public static double TinhTienBanHang(int SoLuong, int GiaBan)
        {
            double kq = 0;
            kq = SoLuong * GiaBan;
            return kq;
        }
        public static double TinhTienBanHang(int SoLuong, int GiaBan, float TyGia) 
        {
            double kq = 0;
            kq = SoLuong * GiaBan * TyGia;
            return kq;
        }
        public static double TinhTienBanHang(int SoLuong, int GiaBan, double TyGia)
        {
            double kq = 0;
            kq = SoLuong * GiaBan * TyGia;
            return kq;
        }
    }
}