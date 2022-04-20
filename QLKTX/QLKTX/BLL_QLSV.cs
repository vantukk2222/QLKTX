using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX
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
        public List<SV> GetAllSV()
        {
            return DataHelper.db.SVs.ToList();
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
            SV SVnew = new SV();
            foreach (SV sv in GetAllSV())
            {
                if (sv.MSSV == mssv)
                {
                    SVnew = sv;
                }
            }
            return SVnew;
        }
        public void DeleteSV(string mssv)
        {
            SV sv = DataHelper.db.SVs.Find(mssv);

            try
            {
                DataHelper.db.SVs.Remove(sv);
                DataHelper.db.SaveChanges();
            }
            catch
            {
                
            }
            
            
        }
    }
}
