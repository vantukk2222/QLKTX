using QLKTX.DTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.BLL
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
        public void DeletePhieu(string MaPhieu)
        {
            Phieu phieu = DataHelper.db.Phieux.Where(p => p.MaPhieu == MaPhieu).FirstOrDefault();
            if (phieu != null)
            {
                DataHelper.db.Phieux.Remove(phieu);
                DataHelper.db.SaveChanges();
            }

        }
    }
}