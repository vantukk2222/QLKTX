using QLKTX.DTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.BLL
{
    public class BLL_AccSV
    {
        private static BLL_AccSV _Instance;
        public static BLL_AccSV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_AccSV();
                return _Instance;
            }
        }
        public void CreateAccSV(string mssv)
        {
            if (DataHelper.db.AccSVs.Where(x => x.MSSV == mssv).Count() == 0)
            {
                AccSV acc = new AccSV { MSSV = mssv, UserName = mssv, PassWord = mssv };

                DataHelper.db.AccSVs.Add(acc);
                DataHelper.db.SaveChanges();
            }
        }
        public bool CheckPassword(SV sv, string pass)
        {
            if (sv.AccSV.PassWord.Trim() == pass)
                return true;
            return false;
        }
        public void ChangePassword(SV sv, string pass)
        {
            sv.AccSV.PassWord = pass;
            DataHelper.db.SaveChanges();
        }
    }
}
