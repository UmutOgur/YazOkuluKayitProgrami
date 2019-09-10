using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
  public  class EntityOgretmen
    {
        private int ogrtid;
        private string ogrtadsoyad;
        private int ogrtbrans;

        public int OGRTID
        {
            get
            {
                return ogrtid;
            }

            set
            {
                ogrtid = value;
            }
        }

        public string OGRTADSOYAD
        {
            get
            {
                return ogrtadsoyad;
            }

            set
            {
                ogrtadsoyad = value;
            }
        }

        public int OGRTBRANS
        {
            get
            {
                return ogrtbrans;
            }

            set
            {
                ogrtbrans = value;
            }
        }
    }
}
