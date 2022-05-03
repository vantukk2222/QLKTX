using QLKTX.DTA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.BLL
{
    internal class BLL_QLSV
    {
       // public static QLKTXEntities1 db = new QLKTXEntities1();
        
        private static BLL_QLSV _Instance;
        public static BLL_QLSV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_QLSV();
                return _Instance;
            }
        }
        public List<string> GetAllKhoa()
        {
            List<string> KhoaHoc = new List<string>();
            foreach (SV sv in GetAllSV())
            {
                KhoaHoc.Add(sv.KhoaHoc);
            }
            return KhoaHoc;
        }

        public List<SV> GetAllSV()
        {
            return DataHelper.db.SVs.ToList();
        }
        public List<SV> GetAllSVKhoaTen(string khoa, string name)
        {
            List<SV> SinhVien = (from SV in DataHelper.db.SVs
                                    where SV.KhoaHoc.Contains(khoa) & SV.HoTen.Contains(name)
                                    select SV).ToList();
            return SinhVien;
        }
        public List<SV> GetAllSVContainName(string name)
        {
            return DataHelper.db.SVs.Where(sv=>sv.HoTen.Contains(name)).ToList();
        }
        public List<SV> GetListSVByMaPhong(string maphong)
        {
            return DataHelper.db.SVs.Where(sv => sv.MaPhong == maphong).ToList();
        }
        public SV GetSVByMSSV(string mssv)
        {
            return DataHelper.db.SVs.Find(mssv);
        }
        public void EditSV(SV sv)
        {
            SV newSV = DataHelper.db.SVs.Find(sv.MSSV);
            if (newSV != null)
            {
                newSV = sv;
                DataHelper.db.SaveChanges();
            }
        }
        public bool checkSV(string mssv)
        {
            return DataHelper.db.SVs.Find(mssv) != null;
        }
        public void AddSV(SV sv)
        {
            try
            {
                DataHelper.db.SVs.Add(sv);
                BLL_AccSV.Instance.CreateAccSV(sv.MSSV);
                DataHelper.db.SaveChanges();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Thêm không thành công");
            }

        }
        public void DeleteSV(string mssv)
        {
            SV sv = DataHelper.db.SVs.Find(mssv);

            try
            {
                if(sv.Phong!=null)
                    sv.Phong.SoNguoiHienTai--;
                DataHelper.db.SVs.Remove(sv);
                DataHelper.db.SaveChanges();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Xóa Không thành công");
            }


        }
    }
}
