using Library.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Helpers
{
    public class DatabaseCrudHelper
    {
        private static SqlConnection con;
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataSet ds;
        private static string connectionString = "server=.;Database=library;trusted_connection=true;";
        public static void ConnectionOpen()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public static void ConnectionSql()
        {
            con = new SqlConnection(connectionString);
        }
        public DatabaseCrudHelper()
        {
            ConnectionSql();
            ConnectionOpen();
        }
        public static void KitapEkle(Kitap kitap,Label label)
        {
            string query = "insert into Kitaplar(KitapAd,KitapYazari,KitapBaskiYil,KitapSayfaSayi,KitapDil,KitapYayinEvi,KitapAciklama) values(@kitapad,@kitapyazar,@kitapbaski,@kitapsayfasayi,@kitapdil,@kitapyayinevi,@kitapaciklama)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@kitapad", kitap.KitapAd);
            cmd.Parameters.AddWithValue("@kitapyazar", kitap.KitapYazari);
            cmd.Parameters.AddWithValue("@kitapbaski", kitap.KitapBaskiYil);
            cmd.Parameters.AddWithValue("@kitapsayfasayi", kitap.KitapSayfaSayi);
            cmd.Parameters.AddWithValue("@kitapdil", kitap.KitapDil);
            cmd.Parameters.AddWithValue("@kitapyayinevi", kitap.KitapYayinEvi);
            cmd.Parameters.AddWithValue("@kitapaciklama", kitap.KitapAciklama);
            cmd.ExecuteNonQuery();
            con.Close();
            label.Text = "Ekleme Başarılı\nKitaplar";
        }
    }
}
