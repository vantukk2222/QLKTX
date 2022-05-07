using QLKTX.DTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.BLL
{
    internal class BLL_HoaDon
    {
        private static BLL_HoaDon _Instance;
        public static BLL_HoaDon Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_HoaDon();
                return _Instance;
            }
        }
        public List<HoaDon> getAllHoaDon()
        {
            return DataHelper.db.HoaDons.ToList();
        }
        public List<HoaDon> getHoaDonByDate(DateTime start, DateTime end)
        {
            return DataHelper.db.HoaDons.Where(x => x.NgayLap >= start && x.NgayLap <= end).ToList();
        }
        public int GetLastMaHoaDon()
        {
            int MaHoaDon;
            if (DataHelper.db.HoaDons.Count() == 0)
            {
                MaHoaDon = 1;
            }
            else
            {
                MaHoaDon = Convert.ToInt32(DataHelper.db.HoaDons.Max(p => p.MaHoaDon).Substring(1)) + 1;
            }
            return MaHoaDon;
        }
        public bool CheckHoaDonThang(SV sv,string TenHoaDon)
        {
            bool check = false;
            foreach (HoaDon i in sv.HoaDons)
            {
                if (i.TenHoaDon == TenHoaDon)
                {
                    check = true;
                    break;
                }
            }

           return check;
        }
        public void createHoaDonTienPhongBySV(SV sv)
        {
            string TenHoaDon = "Tiền Phòng " + sv.Phong.TenPhong.Trim() + " Tháng " + DateTime.Now.Month + "/" + DateTime.Now.Year;
            if (CheckHoaDonThang(sv, TenHoaDon))
                return;
            string MaHoaDon = "B" + Convert.ToString(GetLastMaHoaDon()).PadLeft(5, '0');
            HoaDon temp = new HoaDon { 
                NgayLap = DateTime.Now.Date,
                MSSV = sv.MSSV,
                MaHoaDon = MaHoaDon,
                TenHoaDon = TenHoaDon,
                DienNuoc =false,
                status =false,
                TienPhong = sv.Phong.GiaPhong.Value
            };
            DataHelper.db.HoaDons.Add(temp);
            DataHelper.db.SaveChanges();
        }
        public void CreateHoaDonMonthly()
        {
            List<SV> sv = DataHelper.db.SVs.ToList();
            foreach(SV i in sv)
            {
                createHoaDonTienPhongBySV(i);
            }
        }
    }
}
