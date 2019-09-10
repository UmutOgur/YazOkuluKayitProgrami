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
   public class DALTalepBavuru
    {
        public static List<EntityBasvuruForm> TalepListesi()
        {
            List<EntityBasvuruForm> degerler = new List<EntityBasvuruForm>();
            SqlCommand komut = new SqlCommand("select * from TBLBASVURU", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityBasvuruForm ent = new EntityBasvuruForm();
                ent.BASVURUID = int.Parse(dr["BASVURUID"].ToString());
                ent.BASOGRID = int.Parse(dr["OGRID"].ToString());
                ent.BASDERSİD = int.Parse(dr["DERSID"].ToString());

                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
    }
}
