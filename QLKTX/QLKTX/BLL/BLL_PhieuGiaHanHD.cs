using QLKTX.DTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.BLL
{
    public class BLL_PhieuGiaHanHD
    {
        private static BLL_PhieuGiaHanHD _Instance;

        public static BLL_PhieuGiaHanHD Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_PhieuGiaHanHD();
                return _Instance;
            }
        }
        public int GetLastMaPhieuGiaHan()
        {
            int MaPhieu = 0;
            if (DataHelper.db.PhieuGiaHanHDs.Count() == 0)
            {
                MaPhieu = 1;
            }
            else
            {
                MaPhieu = Convert.ToInt32(DataHelper.db.PhieuGiaHanHDs.Max(p => p.MaPhieu).Substring(2)) + 1;
            }
            return MaPhieu;
        }
        public List<PhieuGiaHanHD> getAllPhieu()
        {
            return DataHelper.db.PhieuGiaHanHDs.ToList();
        }
        public void AddPhieuGiaHan(PhieuGiaHanHD p)
        {

            DataHelper.db.PhieuGiaHanHDs.Add(p);
            DataHelper.db.Phieux.Add(new Phieu { MaPhieu = p.MaPhieu, MSSV = p.HopDong.SVs.FirstOrDefault().MSSV, TenPhieu = "Phiếu Gia Hạn", NgayLap = DateTime.Now.Date, status = false });
            DataHelper.db.SaveChanges();
        }
        public void DeletePhieuGH(PhieuGiaHanHD p)
        {
            DataHelper.db.PhieuGiaHanHDs.Remove(p);
            DataHelper.db.SaveChanges();
        }
        public PhieuGiaHanHD SearchPhieuGH(string maPhieu)
        {
            return DataHelper.db.PhieuGiaHanHDs.Find(maPhieu);
        }
        public void DuyetPhieuGiaHan(PhieuGiaHanHD p)
        {
            p.Phieu.status = true;
            BLL_HopDong.Instance.GiaHan(p.HopDong,p.SoNamGiaHan);
        }

        
    }
}
