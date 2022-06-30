using QLKTX.DTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.BLL
{
    internal class BLL_PhieuDKOKTX
    {
        private static BLL_PhieuDKOKTX _Instance;

        public static BLL_PhieuDKOKTX Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_PhieuDKOKTX();
                return _Instance;
            }
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
                MaPhieu = Convert.ToInt32(DataHelper.db.PhieuDangKyOKTXes.Max(p => p.MaPhieu).Substring(2)) + 1;
            }
            return MaPhieu;
        }

        public List<PhieuDangKyOKTX> GetAllPhieuDKOKTX()
        {
            return DataHelper.db.PhieuDangKyOKTXes.ToList();
        }

        public void AddPhieuDKOKTX(PhieuDangKyOKTX p)
        {

            DataHelper.db.PhieuDangKyOKTXes.Add(p);
            DataHelper.db.Phieux.Add(new Phieu { MaPhieu = p.MaPhieu, TenPhieu = "Phiếu Đăng Ký OKTX", NgayLap = DateTime.Now.Date, status = false });
            DataHelper.db.SaveChanges();
        }
        public void DuyetPhieuDKOKTX(PhieuDangKyOKTX p)
        {
            if (DataHelper.db.SVs.Find(p.MSSV) == null)
            {
                BLL_HopDong.Instance.AddHopDong();
                SV temp = new SV
                {
                    MSSV = p.MSSV,
                    HoTen = p.HoTen,
                    NgaySinh = p.NgaySinh,
                    GioiTinh = p.GioiTinh,
                    QueQuan = p.QueQuan,
                    Khoa = p.Khoa,
                    KhoaHoc = p.KhoaHoc,
                    LopHoc = p.LopHoc,
                    SDT = p.SDT,
                    HeDaoTao = p.HeDaoTao,
                    MaHopDong = "HD" + Convert.ToString(BLL_HopDong.Instance.GetLastMaHopDong()).PadLeft(4, '0')
                };
                BLL_QLSV.Instance.AddSV(temp);
                BLL_Acc.Instance.setAccSV(temp,p.PassWord,p.Username);
                BLL_QLPhong.Instance.AddSVIntoPhong(BLL_QLPhong.Instance.getPhongNotFullByGender(temp.GioiTinh), temp);
                DataHelper.db.Phieux.Find(p.MaPhieu).status = true;
            }
            DataHelper.db.SaveChanges();
        }
        public void DeletePhieuDKOKTX(PhieuDangKyOKTX p)
        {
            DataHelper.db.Phieux.Remove(p.Phieu);
            DataHelper.db.SaveChanges();
        }
        public PhieuDangKyOKTX SearchPhieuDK(string maPhieu)
        {
            return DataHelper.db.PhieuDangKyOKTXes.Find(maPhieu);
        }
    }
}
