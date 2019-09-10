using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALOgrenci
    {

        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLOGRENCI (OGRAD,OGRSOYAD,OGRNUMARA,OGRFOTOGRAF,OGRSIFRE) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.OrgAd);
            komut1.Parameters.AddWithValue("@p2", parametre.OgrSoyad);
            komut1.Parameters.AddWithValue("@p3", parametre.OgrNumara);
            komut1.Parameters.AddWithValue("@p4", parametre.OgrFotograf);
            komut1.Parameters.AddWithValue("@p5", parametre.OgrSifre);
            return komut1.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("select * from TBLOGRENCI", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OgrId = Convert.ToInt32(dr["OGRID"]);
                ent.OrgAd = dr["OGRAD"].ToString();
                ent.OgrSoyad = dr["OGRSOYAD"].ToString();
                ent.OgrNumara = dr["OGRNUMARA"].ToString();
                ent.OgrFotograf = dr["OGRFOTOGRAF"].ToString();
                ent.OgrSifre = dr["OGRSIFRE"].ToString();
                ent.OgrBakiye = Convert.ToDouble(dr["OGRBAKIYE"]);
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete From TBLOGRENCI where OGRID=@p1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("select * from TBLOGRENCI where OGRID=@p1", Baglanti.bgl);
            komut4.Parameters.AddWithValue("@p1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OrgAd = dr["OGRAD"].ToString();
                ent.OgrSoyad = dr["OGRSOYAD"].ToString();
                ent.OgrNumara = dr["OGRNUMARA"].ToString();
                ent.OgrFotograf = dr["OGRFOTOGRAF"].ToString();
                ent.OgrSifre = dr["OGRSIFRE"].ToString();
                ent.OgrBakiye = Convert.ToDouble(dr["OGRBAKIYE"]);
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGüncelle(EntityOgrenci degerler)
        {

            SqlCommand komut5 = new SqlCommand("Update TBLOGRENCI Set OGRAD=@p2,OGRSOYAD=@p3,OGRNUMARA=@p4,OGRFOTOGRAF=@p5,OGRSIFRE=@p6 where OGRID=@p1", Baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@p1", degerler.OgrId);
            komut5.Parameters.AddWithValue("@p2", degerler.OrgAd);
            komut5.Parameters.AddWithValue("@p3", degerler.OgrSoyad);
            komut5.Parameters.AddWithValue("@p4", degerler.OgrNumara);
            komut5.Parameters.AddWithValue("@p5", degerler.OgrFotograf);
            komut5.Parameters.AddWithValue("@p6", degerler.OgrSifre);
            return komut5.ExecuteNonQuery() > 0;
        }
    }
}
