using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
  public class EntityBasvuruForm
    {
        private int basvuruid;
        private int basogrid;
        private int basdersid;

        public int BASVURUID
        {
            get
            {
                return basvuruid;
            }

            set
            {
                basvuruid = value;
            }
        }

        public int BASOGRID
        {
            get
            {
                return basogrid;
            }

            set
            {
                basogrid = value;
            }
        }

        public int BASDERSİD
        {
            get
            {
                return basdersid;
            }

            set
            {
                basdersid = value;
            }
        }
    }
}
