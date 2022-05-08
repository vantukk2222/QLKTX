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
            string TenHoaDon = "Tiền Phòng " +  " Tháng " + DateTime.Now.Month + "/" + DateTime.Now.Year;
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
        public List<HoaDon> GetHoaDons(string msv)
        {
            var l1 = DataHelper.db.HoaDons.Where(p => p.MSSV == msv).Select(p => p);
            return l1.ToList();
        }
        public void ThanhToanPhong(string mssv, DateTime ngaylap)
        {
            HoaDon hoadon = DataHelper.db.HoaDons.Where(p => p.MSSV == mssv && p.NgayLap == ngaylap).Select(p => p).FirstOrDefault();
            hoadon.NgayThu = DateTime.Now.Date;
            hoadon.status = true;
            DataHelper.db.SaveChanges();
        }
        public void ThanhToanDN(string mssv, DateTime ngaylap)
        {
            HoaDon hoadon = DataHelper.db.HoaDons.Where(p => p.MSSV == mssv && p.NgayLap == ngaylap).Select(p => p).FirstOrDefault();

            hoadon.NgayThu = DateTime.Now.Date;
            hoadon.DienNuoc = true;
            var listhoadon = DataHelper.db.HoaDons.Where(p => p.TenHoaDon.Contains(hoadon.TenHoaDon)).Select(p => p);
            foreach (HoaDon i in listhoadon)
            {
                DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                i.DienNuoc = true;
                i.NgayThu = dt;
            }

            DataHelper.db.SaveChanges();
        }
    }
}
