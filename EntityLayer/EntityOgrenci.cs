using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private string ograd;
        private string ogrsoyad;
        private int ogrid;
        private string ogrnumara;
        private string ogrfotoğraf;
        private double ogrbakiye;
        private string ogrsifre;

        public string OrgAd
        {
            get
            {
                return ograd;
            }

            set
            {
                ograd = value;
            }
        }

        public string OgrSoyad
        {
            get
            {
                return ogrsoyad;
            }

            set
            {
                ogrsoyad = value;
            }
        }

        public int OgrId
        {
            get
            {
                return ogrid;
            }

            set
            {
                ogrid = value;
            }
        }

        public string OgrNumara
        {
            get
            {
                return ogrnumara;
            }

            set
            {
                ogrnumara = value;
            }
        }

        public string OgrFotograf
        {
            get
            {
                return ogrfotoğraf;
            }

            set
            {
                ogrfotoğraf = value;
            }
        }

        public double OgrBakiye
        {
            get
            {
                return ogrbakiye;
            }

            set
            {
                ogrbakiye = value;
            }
        }

        public string OgrSifre
        {
            get
            {
                return ogrsifre;
            }

            set
            {
                ogrsifre = value;
            }
        }
    }
}
