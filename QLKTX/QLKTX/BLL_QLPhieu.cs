using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX
{
    internal class BLL_QLPhieu
    {
        private static BLL_QLPhieu _Instance;

        public static BLL_QLPhieu Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_QLPhieu();
                return _Instance;
            }
        }
        public List<Phieu> GetAllPhieu()
        {
            return DataHelper.db.Phieux.ToList();
        }
        public List<string> GetAllTenPhieu()
        {
            List<string> KhuName = new List<string>();
            foreach (Phieu TenPhieu in GetAllPhieu())
            {
                KhuName.Add(TenPhieu.TenPhieu);
            }

            return KhuName;
        }
        public List<Phieu> GetAllLoaiTen(string Loai, string TenSV)
        {
            if (Loai == "All") Loai = "";
            var phieu = (from p in DataHelper.db.Phieux
                         join sv in DataHelper.db.SVs on p.MSSV equals sv.MSSV
                         where (p.TenPhieu.Contains(Loai) & sv.HoTen.Contains(TenSV))
                         select p).ToList();

            // (from p in DataHelper.db.Phieux
            //join sv in DataHelper.db.SVs on p.MSSV equals sv.MSSV
            // where (p.TenPhieu.Contains(Loai) & sv.HoTen.Contains(TenSV))
            // select new { p, sv }).ToList();
            return phieu;

        }
        public int GetLastMaPhieuDKOKTX()
        {
            int MaPhieu = 0;
            if (DataHelper.db.PhieuDangKyOKTXes.Count() == 0)
            {
                MaPhieu = 1;
            }
            else
            {
                MaPhieu =Convert.ToInt32( DataHelper.db.PhieuDangKyOKTXes.Max(p => p.MaPhieu).Substring(2)) + 1;
            }
            return MaPhieu;
        }
        public void AddPhieuDKOKTX(PhieuDangKyOKTX p)
        {
            
            DataHelper.db.PhieuDangKyOKTXes.Add(p);
            DataHelper.db.Phieux.Add(new Phieu { MaPhieu = p.MaPhieu, TenPhieu = "Phiếu Đăng Ký OKTX", NgayLap = DateTime.Now.Date });
            DataHelper.db.SaveChanges();
        }
    }
}