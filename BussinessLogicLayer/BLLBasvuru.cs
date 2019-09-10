using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BussinessLogicLayer
{
   public class BLLBasvuru
    {
        public static List<EntityBasvuruForm> BllBasvuru()
        {
            return DALTalepBavuru.TalepListesi();
        }
    }
}
