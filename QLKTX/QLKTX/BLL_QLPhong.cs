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
        public static QLKTXEntities1 db = new QLKTXEntities1();
        
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
        public DbSet<Phong>  GetAllPhong()
        {
            return db.Phongs;
        }
    }
}
