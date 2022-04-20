using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX
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
        public List<Phong>GetAllPhong()
        {
            return DataHelper.db.Phongs.ToList();
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
        public List<SV> ShowSVPhong(string Maphong)
        {
            return db.SVs.Where(sv => sv.MaPhong.Contains(Maphong)).ToList();


        }
    }
}
