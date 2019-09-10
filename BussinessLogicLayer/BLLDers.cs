using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BussinessLogicLayer
{
  public  class BLLDers
    {
        public static List<EntityDers> BllListele()
        {
            return DALDers.DersListesi();
        } 
        public static int TalepEkleBLL (EntityBasvuruForm p)
        {
            if (p.BASDERSİD !=null && p.BASOGRID !=null)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }
    }
}
