using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai03
{
    public partial class PhanSo
    {
        #region 1-Full Properties 
        private int _TuSo=1;
        public int TuSo
        {
            get { return _TuSo; }
            set { _TuSo = value; }
        }
        private int _MauSo=1;
        public int MauSo
        {
            get { return _MauSo; }
            set 
            {
                if (value != 0)
                    _MauSo = value;
                else
                    throw new Exception("Mẫu số phải khác 0");
            }
        }
        #endregion
        #region 2-Constructor
        public PhanSo() { }
        public PhanSo(int TuSo,int MauSo)
        {
            this.TuSo = TuSo;
            this.MauSo = MauSo;
        }
        #endregion
        #region 3-Methods
        public string Xuat()
        {
            string kq= _TuSo + "/" + _MauSo;
            return kq;
        }
        public static PhanSo Parse(string chuoi)
        {
            try
            {
                string[] s = chuoi.Split('/');
                if (s.Length != 2) throw new Exception("Dữ liệu không chuyển được thành PhanSo");
                int tuSo,mauSo;
                if (!int.TryParse(s[0], out tuSo)) throw new Exception("Dữ liệu [Tử số] không hợp lệ");
                if (!int.TryParse(s[1], out mauSo)) throw new Exception("Dữ liệu [Mẫu số] không hợp lệ");
                PhanSo kq=new PhanSo(tuSo, mauSo);
                return kq;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static bool TryParse(string chuoi, out PhanSo p)
        {
            p = null;
            string[] s = chuoi.Split('/');
            if (s.Length != 2) return false;                
            int tuSo, mauSo;
            if (!int.TryParse(s[0], out tuSo)) return false;
            if (!int.TryParse(s[1], out mauSo)) return false;
            p = new PhanSo(tuSo,mauSo);                
            return true;
        }
        #endregion    
        // 
        // 1/2 + 1/4 = 6/8
        public PhanSo Cong(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq._TuSo = _TuSo * p._MauSo + _MauSo * p._TuSo;
            kq._MauSo = _MauSo * p._MauSo;
            kq.ToiGian();
            return kq;
        }
        private int Tim_uscln(int x,int y )
        {
            x = Math.Abs(x);
            y = Math.Abs(y);
            int min = Math.Min(x, y);
            int i;
            for(i=min;i>=1;i--)
            {
                if (x % i == 0 && y % i == 0) break;
            }
            return i;
        }
        public void ToiGian()
        {
            if (_TuSo == 0) return;
            int uscln = Tim_uscln(_TuSo, _MauSo);
            _TuSo = _TuSo / uscln;
            _MauSo = _MauSo / uscln;
        }
             

    }
}