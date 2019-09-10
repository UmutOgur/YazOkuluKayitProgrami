using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BussinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.OrgAd != null && p.OgrSoyad != null && p.OgrNumara != null && p.OgrFotograf != null && p.OgrSifre != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciListesi();
        }
        public static bool OgrenciSilBLL(int Parametre)
        {
            if (Parametre>=0)
            {
                return DALOgrenci.OgrenciSil(Parametre);
            }
            return true;
        }
        public static List<EntityOgrenci> BllDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }
        public static bool OgrenciGuncelleBLL(EntityOgrenci p)
        {
            if (p.OrgAd != null && p.OrgAd != "" && p.OgrSoyad != null && p.OgrSoyad != "" && p.OgrNumara != null && p.OgrNumara != "" && p.OgrFotograf != null && p.OgrFotograf != "" && p.OgrSifre != null && p.OgrSifre != "" && p.OgrId>0)
            {
                return DALOgrenci.OgrenciGüncelle(p);
            }
            return false;
        }
    }
}
