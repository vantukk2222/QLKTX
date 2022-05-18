using QLKTX.DTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.BLL
{
    public class BLL_DienNuoc
    {
        private static BLL_DienNuoc _Instance;
        public static BLL_DienNuoc Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_DienNuoc();
                return _Instance;
            }
        }

        public string NewMaDienNuoc()
        {
            return "DN" + Convert.ToString(BLL_DienNuoc.Instance.GetLastMaDienNuoc() + 1).PadLeft(4, '0');
        }
        public int GetLastMaDienNuoc()
        {
            var hd = DataHelper.db.DienNuocs.OrderByDescending(p => p.MaDienNuoc).FirstOrDefault();
            if (hd == null)
                return 0;
            else
            {
                string ma = hd.MaDienNuoc;
                int i = int.Parse(ma.Substring(2));
                return i;
            }

        }
    }
}
