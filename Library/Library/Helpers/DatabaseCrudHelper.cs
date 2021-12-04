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
        public static void GetList(DataGridView gridView,string query)
        {
            try
            {
                ConnectionSql();
                ConnectionOpen();
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridView.DataSource = dt;
                con.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        //Insert
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
        public static void EmanetEkle(Emanet emanet,Label label)
        {
            string query = "insert into Emanetler(UyeNo,KitapNo,EmanetVermeTarih,EmanetGeriAlmatarih,EmanetNot,EmanetTeslimEdildi)values(@uyeno,@kitapno,@vermetarih,@almatarih,@not,@teslim)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@uyeno", emanet.UyeNo);
            cmd.Parameters.AddWithValue("@kitapno", emanet.KitapNo);
            cmd.Parameters.AddWithValue("@vermetarih", emanet.EmanetVermeTarih);
            cmd.Parameters.AddWithValue("@almatarih", emanet.EmanetGeriAlmaTarih);
            //cmd.Parameters.AddWithValue("@ıslemtarih", DateTime.Parse(reverseDate(maskedIslemTarihi.Text)));
            cmd.Parameters.AddWithValue("@not", emanet.EmanetNot);
            cmd.Parameters.AddWithValue("@teslim", emanet.EmanetTeslimEdildi);

            cmd.ExecuteNonQuery();
            con.Close();
            label.Text = "Ekleme Başarılı\nEmanetler";
        }
        public static void UyeEkle(Uye uye,Label label)
        {
            string uyeKayit = "insert into Uyeler(UyeAd,UyeSoyad,UyeTelefon,UyeEposta,UyeAdres) values(@ad,@soyad,@telefon,@eposta,@adres)";
            cmd = new SqlCommand(uyeKayit, con);
            cmd.Parameters.AddWithValue("@ad", uye.UyeAd);
            cmd.Parameters.AddWithValue("@soyad", uye.UyeSoyad);
            cmd.Parameters.AddWithValue("@telefon", uye.UyeTelefon);
            cmd.Parameters.AddWithValue("@eposta", uye.UyeEposta);
            cmd.Parameters.AddWithValue("@adres", uye.UyeAdres);
            cmd.ExecuteNonQuery();
            con.Close();
            label.Text = "Ekleme Başarılı\nUyeler";
        }
        
        //Delete
        public static void KitapSil(int id,Label label)
        {
            string query = "delete from Kitaplar where KitapNo=@id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
            label.Text = "Silme Başarılı\nKitaplar";
        }
        public static void EmanetSil(int id, Label label)
        {
            string query = "delete from Emanetler where EmanetNo=@id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
            label.Text = "Silme Başarılı\nEmanetler";
        }
        public static void UyeSil(int id, Label label)
        {
            string query = "delete from Uyeler where UyeNo=@id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
            label.Text = "Silme Başarılı\nUyeler";
        }

        //Update
        public static void KitapGuncelle(Kitap kitap, Label label)
        {
            
        }
        public static void EmanetGuncelle(Emanet emanet, Label label)
        {
            
        }
        public static void UyeGuncelle(Uye uye, Label label)
        {
            
        }
    }
}
