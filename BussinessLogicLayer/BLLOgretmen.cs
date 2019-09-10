using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BussinessLogicLayer
{
   public class BLLOgretmen
    {
        public static List<EntityOgretmen> BllOgretmen()
        {
            return DALOgretmen.OgretmenListele();
        }
    }
}
