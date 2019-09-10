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
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut2 = new SqlCommand("select * from TBLDERS", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.DERSID = Convert.ToInt32(dr["DERSID"]);
                ent.DERSAD = dr["DERSAD"].ToString();
                ent.DERSMINKONT = int.Parse(dr["DERSMINSKONT"].ToString());
                ent.DERSMAXKONT = int.Parse(dr["DERSMAKSKONT"].ToString());

                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into TBLBASVURU (OGRID,DERSID) values(@p1,@p2)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", parametre.BASOGRID);
            komut.Parameters.AddWithValue("@p2", parametre.BASDERSİD);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }
    }
}
