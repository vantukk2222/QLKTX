using QLKTX.DTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.BLL
{
    public class BLL_PhieuKyLuat
    {
        private static BLL_PhieuKyLuat _Instance;
        public static BLL_PhieuKyLuat Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_PhieuKyLuat();
                return _Instance;
            }
        }
        public int GetLastMaPhieuKyLuat()
        {
            int MaPhieu = 0;
            if (DataHelper.db.PhieuKyLuats.Count() == 0)
            {
                MaPhieu = 1;
            }
            else
            {
                MaPhieu = Convert.ToInt32(DataHelper.db.PhieuKyLuats.Max(p => p.MaPhieu).Substring(2)) + 1;
            }
            return MaPhieu;
        }
        public void AddPhieuKyLuat(PhieuKyLuat p)
        {

            DataHelper.db.PhieuKyLuats.Add(p);
            DataHelper.db.SaveChanges();
        }
        public List<PhieuKyLuat> GetPhieuKyLuats(string msv)
        {
            var l1 = DataHelper.db.PhieuKyLuats.Where(p => p.Phieu.MSSV == msv).Select(p => p);
            return l1.ToList();
        }

        public void NopPhat(string msv, DateTime dt)
        {
            Phieu temp = DataHelper.db.Phieux.Where(p => p.MSSV == msv && p.NgayLap == dt).FirstOrDefault();
            temp.status = true;
            DataHelper.db.SaveChanges();
        }
        public int SoPhieuKyLuatChuaThanhToan(SV sv)
        {
            int count = 0;
            var l1 = DataHelper.db.PhieuKyLuats.Where(p => p.Phieu.MSSV == sv.MSSV && p.Phieu.status == false).Select(p => p);
            count = l1.Count();
            return count;
        }
    }
}
