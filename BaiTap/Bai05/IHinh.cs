using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.Bai05
{
    public interface IHinh
    {
        // Định nghĩa cách thức khai báo các thành phần (mà class thực thi cần phải cài đặt)
        string TenHinh { get; }
        double DienTich();
        double ChuVi();
        string XuatThongTin(string XuongDong = "\r\n");

    }
}
