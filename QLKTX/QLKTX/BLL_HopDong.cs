using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLKTX
{
    internal class BLL_HopDong
    {
        private static BLL_HopDong _Instance;
        public static BLL_HopDong Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_HopDong();
                return _Instance;
            }
        }
        
        public void AddHopDong(HopDong hd)
        {
            DataHelper.db.HopDongs.Add(hd);
            DataHelper.db.SaveChanges();
        }
        public int GetLastMaHopDong()
        {
            var hd = DataHelper.db.HopDongs.OrderByDescending(p => p.MaHopDong).FirstOrDefault();
            if (hd == null)
                return 1;
            else
            {
                string ma = hd.MaHopDong;
                int i = int.Parse(ma.Substring(2)) + 1;
                return i;
            }
            
        }
    }
}
