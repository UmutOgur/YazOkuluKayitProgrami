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
    public class DALOgretmen
    {
        public static List<EntityOgretmen> OgretmenListele()
        {
            List<EntityOgretmen> degerler = new List<EntityOgretmen>();
            SqlCommand komut = new SqlCommand("select * from TBLOGRETMEN", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgretmen ent = new EntityOgretmen();
                ent.OGRTID = int.Parse(dr["OGRTID"].ToString());
                ent.OGRTADSOYAD = dr["OGRTADSOYAD"].ToString();
                ent.OGRTBRANS = int.Parse(dr["OGRTBRANS"].ToString());

                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
    }
}
