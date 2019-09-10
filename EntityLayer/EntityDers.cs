using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityDers
    {
        private int dersid;
        private string dersad;
        private int dersminkont;
        private int dersmaxkont;

        public int DERSID
        {
            get
            {
                return dersid;
            }

            set
            {
                dersid = value;
            }
        }

        public string DERSAD
        {
            get
            {
                return dersad;
            }

            set
            {
                dersad = value;
            }
        }

        public int DERSMINKONT
        {
            get
            {
                return dersminkont;
            }

            set
            {
                dersminkont = value;
            }
        }

        public int DERSMAXKONT
        {
            get
            {
                return dersmaxkont;
            }

            set
            {
                dersmaxkont = value;
            }
        }
    }
}
