using QLKTX.DTA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLKTX.BLL
{
    internal class BLL_QLPhong
    {
        //public static QLKTXEntities1 db = new QLKTXEntities1();

        private static BLL_QLPhong _Instance;
        public static BLL_QLPhong Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_QLPhong();
                return _Instance;
            }
        }
        public List<Khu> GetAllKhu()
        {
            return DataHelper.db.Khus.ToList();
        }
        public List<string> GetNameKhu()
        {
            List<string> KhuName = new List<string>();
            foreach (Khu tenkhu in GetAllKhu())
            {
                KhuName.Add(tenkhu.MaKhu);
            }

            return KhuName;
        }
        public List<Phong>GetAllPhong()
        {
            return DataHelper.db.Phongs.ToList();
        }
        public List<Phong> GetAllByKhuMa(string makhu, string maphong)
        {
            if (makhu == "All") makhu = "";
            List<Phong> phong = (from p in DataHelper.db.Phongs
                                 where (p.MaKhu.Contains(makhu) & p.MaPhong.Contains(maphong))
                                 select p).ToList();
            return phong;

        }
        public Phong GetPhongByMaPhong(string MaPhong)
        {
            return DataHelper.db.Phongs.Where(p => p.MaPhong == MaPhong).FirstOrDefault();
        }
        public void deletePhong(Phong phong)
        {
            try
            {
                DataHelper.db.Phongs.Remove(phong);
                DataHelper.db.SaveChanges();                
            }
            catch
            {
                
            }
            
            
        }
        public Phong getPhongNotFullByGender(bool gender)
        {
            Khu temp;
            if (gender)
                return DataHelper.db.Phongs.Where(p => p.SoNguoiHienTai < p.SoNguoiToiDa & p.Khu.PhanLoai.Trim() == "Nam").FirstOrDefault();
            else
                return DataHelper.db.Phongs.Where(p => p.SoNguoiHienTai < p.SoNguoiToiDa & p.Khu.PhanLoai.Trim() == "Nu").FirstOrDefault();
        }
        public void AddSVIntoPhong(Phong phong, SV sv)
        {
            phong.SVs.Add(sv);
            phong.SoNguoiHienTai++;
            if (phong.SoNguoiHienTai >= phong.SoNguoiToiDa)
            {
                phong.Status = true;
            }
            DataHelper.db.SaveChanges();
        }
        public List<SV> ShowSVPhong(string Maphong)
        {
            return DataHelper.db.SVs.Where(sv => sv.MaPhong.Contains(Maphong)).ToList();


        }
        public int GetSoPhongDangSuDung()
        {
            return DataHelper.db.Phongs.Where(p => p.SoNguoiHienTai > 0).Count();
        }
        public int GetSoPhongTrong()
        {
            return DataHelper.db.Phongs.Where(p => p.SoNguoiHienTai == 0).Count();
        }
        public int GetSoPhongToiDa()
        {
            return DataHelper.db.Phongs.Count();
        }
    }
}
