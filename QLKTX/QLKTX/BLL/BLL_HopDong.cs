using QLKTX.DTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLKTX.BLL
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
        
        public void AddHopDong()
        {
            HopDong tempHD = new HopDong
            {
                MaHopDong = "HD" + Convert.ToString(BLL_HopDong.Instance.GetLastMaHopDong()+1).PadLeft(4, '0'),
                NgayKy = DateTime.Now.Date,
                NgayHetHan = DateTime.Now.AddYears(1).Date,
                NgayNhanPhong = DateTime.Now.Date,
            };
            DataHelper.db.HopDongs.Add(tempHD);
            DataHelper.db.SaveChanges();
        }
        public int GetLastMaHopDong()
        {
            var hd = DataHelper.db.HopDongs.OrderByDescending(p => p.MaHopDong).FirstOrDefault();
            if (hd == null)
                return 0;
            else
            {
                string ma = hd.MaHopDong;
                int i = int.Parse(ma.Substring(2)) ;
                return i;
            }
            
        }
    }
}
