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
        public static QLKTXEntities1 db = new QLKTXEntities1();

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
            return db.SVs.ToList();
        }
        public List<SV> GetAllContainName(string name)
        {
            return db.SVs.Where(sv => sv.HoTen.Contains(name)).ToList();
        }
        public void DeleteSV(string mssv)
        {
            SV sv = (from member in db.SVs where member.MSSV == mssv select member).FirstOrDefault();
            if (sv != null)
            {
                string MSSV = sv.MSSV;
                db.SVs.Remove(sv);
                
                
            }
        }
    }
}
