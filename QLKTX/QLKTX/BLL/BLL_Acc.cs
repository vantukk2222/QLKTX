using QLKTX.DTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.BLL
{
    public class BLL_Acc
    {
        private static BLL_Acc _Instance;
        public static BLL_Acc Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Acc();
                return _Instance;
            }
        }
        public void CreateAccSV(string mssv)
        {
            if (DataHelper.db.AccSVs.Where(x => x.MSSV == mssv).Count() == 0)
            {
                AccSV acc = new AccSV { MSSV = mssv, UserName = mssv, PassWord = mssv,status=true };

                DataHelper.db.AccSVs.Add(acc);
                DataHelper.db.SaveChanges();
            }
        }
        public bool CheckAccount(string username)
        {
            if (DataHelper.db.AccSVs.Where(x => x.UserName == username).Count() == 1
                || DataHelper.db.PhieuDangKyOKTXes.Where(x => x.Username == username).Count() == 1)
                return true;
            return false;
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
        public void setAccSV(SV sv, string pass, string user)
        {
            sv.AccSV.PassWord = pass;
            sv.AccSV.UserName = user;
        }
        public AccSV LoginSV(string username, string password)
        {
            var l1 = DataHelper.db.AccSVs.Where(x => x.UserName == username && x.PassWord == password);
            if (l1.Count() == 1) 
            { 
                return l1.FirstOrDefault();
            }           
            return null;
        }
        public AccCB LoginCB(string username,string password)
        {
            var l1 = DataHelper.db.AccCBs.Where(x => x.UserName == username && x.PassWord == password);
            if (l1.Count() == 1)
            {
                return l1.FirstOrDefault();
            }
            return null;
        }
    }
}
