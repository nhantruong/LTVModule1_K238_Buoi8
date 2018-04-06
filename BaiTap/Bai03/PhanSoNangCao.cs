using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai03
{
    public partial class PhanSo
    {
        public static PhanSo operator +(PhanSo ps1,PhanSo ps2)
        {
            return ps1.Cong(ps2);
        }
        public static bool operator ==(PhanSo ps1, PhanSo ps2)
        {
            bool kq = false;
            PhanSo p1 = ps1.MemberwiseClone() as PhanSo;
            PhanSo p2 = ps2.MemberwiseClone() as PhanSo;
            p1.ToiGian();
            p2.ToiGian();
            if (p1._TuSo == p2._TuSo && p1._MauSo == p2._MauSo) kq = true;
            return kq;
        }
        public static bool operator !=(PhanSo ps1, PhanSo ps2)
        {
            bool kq = false;
            PhanSo p1 = ps1.Clone();
            PhanSo p2 = ps2.Clone();
            p1.ToiGian();
            p2.ToiGian();
            if (p1._TuSo != p2._TuSo || p1._MauSo != p2._MauSo) kq = true;
            return kq;
        }
        public PhanSo Clone()
        {
            PhanSo kq = new PhanSo(this._TuSo, this._MauSo);
            return kq;
        }
    }
}