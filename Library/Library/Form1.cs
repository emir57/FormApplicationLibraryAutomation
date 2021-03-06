using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library.Helpers;
using Library.Models;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Version
        private string _version = "V2.5";
        //Checks
        public bool defaultCheck = true;
        public bool uyeCheck = false;
        public bool emanetCheck = false;
        public bool kitapCheck = false;
        
        //Date function
        public string reverseDate(string text)
        {
            string[] date = text.Split('-');
            string year = date[2];
            string month = date[1];
            string day = date[0];
            string full = year + "-" + month + "-" + day;
            return full;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseCrudHelper.ConnectionSql();
            string query = "Select u.UyeNo,u.UyeAd,u.UyeSoyad,u.UyeTelefon,u.UyeEposta,u.UyeAdres,k.KitapAd,e.EmanetTeslimEdildi from Kitaplar k, Emanetler e, Uyeler u where e.UyeNo = u.UyeNo and e.KitapNo = k.KitapNo";
            DatabaseCrudHelper.GetList(dataGridView1,query);
            gbxArama.Enabled = true;
            gbxEmanet.Enabled = false;
            gbxArama.Enabled = true;
            groupBox2.Enabled = false;
            CmbBoxTeslim.Hide();
            maskedGeriAlma.Hide();
            maskedIslemTarihi.Hide();
            maskedVerme.Hide();
            label11.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult itOk = MessageBox.Show("Programdan Çıkmak Üzeresiniz", "Program Kapanıyor", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (itOk == DialogResult.OK){ }
            else
            {
                e.Cancel = true;
            }
        }

        private void BtnDefaultList_Click(object sender, EventArgs e)
        {
            gbxEmanet.Enabled = false;
            gbxArama.Enabled = true;
            defaultCheck = true;
            groupBox2.Enabled = false;
            string query = "Select u.UyeNo ,u.UyeAd,u.UyeSoyad,u.UyeTelefon,u.UyeEposta,u.UyeAdres,k.KitapAd,e.EmanetTeslimEdildi from Kitaplar k, Emanetler e, Uyeler u where e.UyeNo = u.UyeNo and e.KitapNo = k.KitapNo";
            DatabaseCrudHelper.GetList(dataGridView1, query);
        }

        private void BtnUyeList_Click(object sender, EventArgs e)
        {
            gbxEmanet.Enabled = false;
            kitapCheck = false;
            emanetCheck = false;
            uyeCheck = false;
            defaultCheck = false;
            defaultCheck = false;

            string query = "Select u.UyeAd,u.UyeSoyad,u.UyeTelefon,u.UyeEposta,u.UyeAdres,e.EmanetTeslimEdildi from Uyeler u left join Emanetler e on e.UyeNo = u.UyeNo";
            groupBox2.Enabled = false;

            DatabaseCrudHelper.GetList(dataGridView1, query);
        }

        private void BtnKitapList_Click(object sender, EventArgs e)
        {
            
            gbxEmanet.Enabled = false;
            kitapCheck = false;
            emanetCheck = false;
            uyeCheck = false;
            defaultCheck = false;

            string query = "Select k.KitapNo, k.KitapAd,k.KitapYayinEvi,e.EmanetNot,e.EmanetVermeTarih,e.EmanetGeriAlmaTarih,e.EmanetIslemTarih, e.EmanetTeslimEdildi from Kitaplar k left join Emanetler e on k.KitapNo= e.KitapNo";
            groupBox2.Enabled = false;
            
            DatabaseCrudHelper.GetList(dataGridView1, query);
        }

        private void BtnKitapAllList_Click(object sender, EventArgs e)
        {
            
            defaultCheck = false;
            kitapCheck = true;
            emanetCheck = false;
            uyeCheck = false;
            
            gbxEmanet.Enabled = false;
            gbxArama.Enabled = true;
            label11.Hide();
            maskedGeriAlma.Hide();
            maskedIslemTarihi.Hide();
            maskedVerme.Hide();
            textBox4.Show();
            textBox5.Show();
            textBox6.Show();
            textBox7.Show();
            textBox8.Show();
            
            string query = "Select * from Kitaplar";
            DatabaseCrudHelper.GetList(dataGridView1, query);
            label1.Text = "No:"; textBox1.ReadOnly = true;
            label2.Text = "Adı:";
            label3.Text = "Yazarı:";
            label4.Text = "Baskı Yılı:";
            label5.Text = "Sayfa Sayısı:";
            label6.Text = "Dili:";
            label7.Text = "Yayın Evi:"; textBox7.Enabled = true;
            label8.Text = "Açıklama:"; textBox8.Enabled = true;
            CmbBoxTeslim.Enabled = false;
            CmbBoxTeslim.Hide();
            groupBox2.Text = "Güncelleme İşlemleri - Kitaplar";
            groupBox2.Enabled = true;
        }

        private void BtnUyeAllList_Click(object sender, EventArgs e)
        {
            
            defaultCheck = false;
            kitapCheck = false;
            emanetCheck = false;
            uyeCheck = true;
            
            gbxEmanet.Enabled = false;
            gbxArama.Enabled = true;
            label11.Hide();
            maskedGeriAlma.Hide();
            maskedIslemTarihi.Hide();
            maskedVerme.Hide();
            textBox4.Show();
            textBox5.Show();
            textBox6.Show();
            textBox7.Hide();
            textBox8.Hide();
            
            string query = "Select * from Uyeler";
            DatabaseCrudHelper.GetList(dataGridView1, query);
            label1.Text = "No:"; textBox1.ReadOnly = true;
            label2.Text = "Ad:";
            label3.Text = "Soyad:";
            label4.Text = "Telefon:";
            label5.Text = "E-posta:";
            label6.Text = "Adres";
            label7.Text = ""; textBox7.Text = "";
            label8.Text = ""; textBox8.Text = "";
            CmbBoxTeslim.Enabled = false;
            CmbBoxTeslim.Hide();
            groupBox2.Text = "Güncelleme İşlemleri - Üyeler";
            groupBox2.Enabled = true;

        }

        private void BtnAllEmanetList_Click(object sender, EventArgs e)
        {
            //**********************************************************
            //Emanet
            defaultCheck = false;
            kitapCheck = false;
            emanetCheck = true;
            uyeCheck = false;
            //Controllers
            gbxEmanet.Enabled = true;
            gbxArama.Enabled = false;
            label11.Show();
            textBox7.Show();
            maskedGeriAlma.Show();
            maskedIslemTarihi.Show();
            maskedVerme.Show();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox8.Hide();
            //****************
            //All Emanet Listed
            string query = "Select * from Emanetler";
            DatabaseCrudHelper.GetList(dataGridView1, query);
            label1.Text = "No:"; textBox1.ReadOnly = true;
            label2.Text = "Uye No:";
            label3.Text = "Kitap No";
            label4.Text = "Verme Tarihi";
            label5.Text = "Geri Alma Tarihi";
            label6.Text = "İşlem Tarihi";
            label7.Text = "Not"; textBox7.Enabled = true;
            label8.Text = "Teslim Edildi"; textBox8.Enabled = false;
            CmbBoxTeslim.Enabled = true;
            CmbBoxTeslim.Show();
            groupBox2.Text = "Güncelleme İşlemleri - Emanetler";
            groupBox2.Enabled = true;


        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //**********************************************************
            //Connection TextBox
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

                //Emanetler
                if (emanetCheck == true)
                {
                    if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "Teslim Edildi")
                    {
                        CmbBoxTeslim.SelectedIndex = 0;
                    }
                    else if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "Sürüyor")
                    {
                        CmbBoxTeslim.SelectedIndex = 2;
                    }
                    else
                    {
                        CmbBoxTeslim.SelectedIndex = 1;
                    }
                    maskedVerme.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    maskedGeriAlma.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    maskedIslemTarihi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                }
                //Uyeler
                if (uyeCheck == true)
                {

                }

            }
            catch{}

        }

        //Update
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Seçili Kaydı Güncellemek Üzeresiniz", "Dikkat!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(DialogResult.Yes==check)
            {
                label9.Text = "";
                label9.Text += "Güncelleme Başarılı";
                if (uyeCheck == true && emanetCheck == false && kitapCheck == false)
                {
                    try
                    {
                        var uye = new Uye
                        {
                            UyeNo = int.Parse(textBox1.Text),
                            UyeAd = textBox2.Text,
                            UyeSoyad = textBox3.Text,
                            UyeTelefon = textBox4.Text,
                            UyeEposta = textBox5.Text,
                            UyeAdres = textBox6.Text
                        };
                        DatabaseCrudHelper.UyeGuncelle(uye, label9);
                        DatabaseCrudHelper.GetList(dataGridView1,DatabaseQueryHelper.QueryUye);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                if (emanetCheck == true && uyeCheck == false && kitapCheck == false)
                {
                    string teslimedilme;

                    if (CmbBoxTeslim.SelectedIndex == 0)
                    {
                        teslimedilme = "Teslim Edildi";
                    }
                    else if (CmbBoxTeslim.SelectedIndex == 2)
                    {
                        teslimedilme = "Sürüyor";
                    }
                    else
                    {
                        teslimedilme = "Teslim Edilmedi";
                    }
                    try
                    {
                        var emanet = new Emanet
                        {
                            EmanetNo=int.Parse(textBox1.Text),
                            UyeNo = int.Parse(textBox2.Text),
                            KitapNo = int.Parse(textBox3.Text),
                            EmanetVermeTarih = DateTime.Parse(reverseDate(maskedVerme.Text)),
                            EmanetGeriAlmaTarih = DateTime.Parse(reverseDate(maskedGeriAlma.Text)),
                            EmanetIslemTarih= DateTime.Parse(reverseDate(maskedIslemTarihi.Text)),
                            EmanetNot = textBox7.Text,
                            EmanetTeslimEdildi = teslimedilme
                        };
                        DatabaseCrudHelper.EmanetGuncelle(emanet, label9);
                        DatabaseCrudHelper.GetList(dataGridView1,DatabaseQueryHelper.QueryEmanet);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }

                }
                if (kitapCheck == true && emanetCheck == false && uyeCheck == false)
                {
                    try
                    {
                        var kitap = new Kitap
                        {
                            KitapNo = int.Parse(textBox1.Text),
                            KitapAd = textBox2.Text,
                            KitapYazari = textBox3.Text,
                            KitapBaskiYil = int.Parse(textBox4.Text),
                            KitapSayfaSayi = int.Parse(textBox5.Text),
                            KitapDil = textBox6.Text,
                            KitapYayinEvi = textBox7.Text,
                            KitapAciklama = textBox8.Text
                        };
                        DatabaseCrudHelper .KitapGuncelle(kitap, label9);
                        DatabaseCrudHelper.GetList(dataGridView1,DatabaseQueryHelper.QueryKitap);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }

                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbxArama.Enabled = false;
            gbxEmanet.Enabled = false;
            defaultCheck = false;
            groupBox2.Enabled = false;

            string query = "Select u.UyeAd, u.UyeSoyad,u.UyeTelefon,u.UyeEposta,k.KitapAd,e.EmanetTeslimEdildi from Kitaplar k, Uyeler u, Emanetler e Where e.EmanetTeslimEdildi = 'Teslim Edildi' and e.UyeNo = u.UyeNo and e.KitapNo = k.KitapNo";
            DatabaseCrudHelper.GetList(dataGridView1, query);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbxArama.Enabled = false;
            gbxEmanet.Enabled = false;
            defaultCheck = false;
            groupBox2.Enabled = false;

            string query = "Select u.UyeAd, u.UyeSoyad,u.UyeTelefon,u.UyeEposta,k.KitapAd,e.EmanetTeslimEdildi from Kitaplar k, Uyeler u, Emanetler e Where e.EmanetTeslimEdildi = 'Sürüyor' and e.UyeNo = u.UyeNo and e.KitapNo = k.KitapNo";
            DatabaseCrudHelper.GetList(dataGridView1, query);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gbxArama.Enabled = false;
            gbxEmanet.Enabled = false;
            defaultCheck = false;
            groupBox2.Enabled = false;

            string query = "Select u.UyeAd, u.UyeSoyad,u.UyeTelefon,u.UyeEposta,k.KitapAd,e.EmanetTeslimEdildi from Kitaplar k, Uyeler u, Emanetler e Where e.EmanetTeslimEdildi = 'Teslim Edilmedi' and e.UyeNo = u.UyeNo and e.KitapNo = k.KitapNo";
            DatabaseCrudHelper.GetList(dataGridView1, query);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        //Clear
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            maskedGeriAlma.Text = "";
            maskedIslemTarihi.Text = "";
            maskedVerme.Text = "";
            CmbBoxTeslim.SelectedIndex = 2;
        }
        
        //Add
        private void button5_Click(object sender, EventArgs e)
        {
            if (kitapCheck==true && emanetCheck ==false && uyeCheck==false)
            {
                try
                {
                    var kitap = new Kitap
                    {
                        KitapAd = textBox2.Text,
                        KitapYazari = textBox3.Text,
                        KitapBaskiYil = int.Parse(textBox4.Text),
                        KitapSayfaSayi = int.Parse(textBox5.Text),
                        KitapDil = textBox6.Text,
                        KitapYayinEvi = textBox7.Text,
                        KitapAciklama = textBox8.Text
                    };
                    DatabaseCrudHelper.KitapEkle(kitap, label9);
                    DatabaseCrudHelper.GetList(dataGridView1,DatabaseQueryHelper.QueryKitap);
                }catch(System.Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }  
            }
            if(emanetCheck==true && uyeCheck==false && kitapCheck ==false)
            {
                try
                {
                    string teslimedilme;

                    if (CmbBoxTeslim.SelectedIndex == 0)
                    {
                        teslimedilme = "Teslim Edildi";
                    }
                    else if (CmbBoxTeslim.SelectedIndex == 2)
                    {
                        teslimedilme = "Sürüyor";
                    }
                    else
                    {
                        teslimedilme = "Teslim Edilmedi";
                    }
                    var emanet = new Emanet
                    {
                        UyeNo = int.Parse(textBox2.Text),
                        KitapNo = int.Parse(textBox3.Text),
                        EmanetVermeTarih = DateTime.Parse(reverseDate(maskedVerme.Text)),
                        EmanetGeriAlmaTarih = DateTime.Parse(reverseDate(maskedGeriAlma.Text)),
                        EmanetNot = textBox7.Text,
                        EmanetTeslimEdildi = teslimedilme
                    };
                    DatabaseCrudHelper .EmanetEkle(emanet, label9);
                    DatabaseCrudHelper.GetList(dataGridView1,DatabaseQueryHelper.QueryEmanet);
                }
                catch(System.Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            if(uyeCheck == true && emanetCheck==false && kitapCheck ==false)
            {
                try
                {
                    var uye = new Uye
                    {
                        UyeAd = textBox2.Text,
                        UyeSoyad = textBox3.Text,
                        UyeTelefon = textBox4.Text,
                        UyeEposta = textBox5.Text,
                        UyeAdres = textBox6.Text
                    };
                    DatabaseCrudHelper.UyeEkle(uye, label9);
                    DatabaseCrudHelper.GetList(dataGridView1,DatabaseQueryHelper.QueryUye);
                }catch(System.Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        //Delete
        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Seçili Kaydı Silmek Üzeresiniz", "Dikkat!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(DialogResult.Yes == check)
            {
                if (uyeCheck == true && emanetCheck == false && kitapCheck == false)
                {
                    try
                    {
                        DatabaseCrudHelper.UyeSil(int.Parse(textBox1.Text), label9);
                        DatabaseCrudHelper.GetList(dataGridView1,DatabaseQueryHelper.QueryUye);
                    }
                    catch{ }
                }
                if (kitapCheck == true && emanetCheck == false && uyeCheck == false)
                {
                    try
                    {
                        DatabaseCrudHelper.KitapSil(int.Parse(textBox1.Text), label9);
                        DatabaseCrudHelper.GetList(dataGridView1,DatabaseQueryHelper.QueryKitap);
                    }
                    catch{ }
                }
                if (emanetCheck == true && kitapCheck == false && uyeCheck == false)
                {
                    try
                    {
                        DatabaseCrudHelper.EmanetSil(int.Parse(textBox1.Text), label9);
                        DatabaseCrudHelper.GetList(dataGridView1,DatabaseQueryHelper.QueryEmanet);
                    }
                    catch{ }
                }
            }          
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in tbxSearch.Text)
            {
                if(item == '\'')
                {
                    tbxSearch.Text = "";
                    MessageBox.Show(" ' işareti kullanılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(item == '#')
                {
                    tbxSearch.Text = "";
                    MessageBox.Show(" # işareti kullanılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            string query="";
            //Kitap Check
            if (kitapCheck == true && uyeCheck == false && emanetCheck == false)
            {
                query = "select * from Kitaplar Where KitapAd like'%"+tbxSearch.Text+ "%' or KitapYazari like'%" + tbxSearch.Text + "%' or KitapYayinEvi like'%" + tbxSearch.Text + "%' or KitapDil like'%" + tbxSearch.Text + "%'";
            }
            //Uye Check
            if (uyeCheck == true && emanetCheck == false && kitapCheck == false)
            {
                query = "select * from Uyeler Where UyeAd like'%" + tbxSearch.Text + "%' or UyeSoyad like'%" + tbxSearch.Text + "%' or UyeEposta like'%" + tbxSearch.Text + "%' or UyeAdres like'%" + tbxSearch.Text + "%'";
            }
            //Emanet Check
            if (emanetCheck == true && kitapCheck == false && uyeCheck == false)
            {
                query = "";
            }
            //Default Check
            if ( defaultCheck==true && emanetCheck == false && kitapCheck == false && uyeCheck == false)
            {
                query = "Select u.UyeNo ,u.UyeAd,u.UyeSoyad,u.UyeTelefon,u.UyeEposta,u.UyeAdres,k.KitapAd,e.EmanetTeslimEdildi from Kitaplar k, Emanetler e, Uyeler u where e.UyeNo = u.UyeNo and e.KitapNo = k.KitapNo and (u.UyeAd like'%" + tbxSearch.Text + "%' or u.UyeSoyad like'%" + tbxSearch.Text + "%' or u.UyeEposta like'%" + tbxSearch.Text + "%' or k.KitapAd like'%" + tbxSearch.Text + "%' or e.EmanetTeslimEdildi like'%" + tbxSearch.Text + "%')";
            }
            try
            {
                DatabaseCrudHelper.GetList(dataGridView1, query);
            }
            catch{}
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void btnEmanetAra_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = Convert.ToDateTime(reverseDate(mtbxStart.Text));
                DateTime end = Convert.ToDateTime(reverseDate(mtbxEnd.Text));
                string query = "";
                if(rbtEmanetGeriAlma.Checked==true)
                {
                    query = "Select * from Emanetler Where EmanetGeriAlmaTarih between '" + reverseDate(mtbxStart.Text) + "' and '" + reverseDate(mtbxEnd.Text) + "'";
                }
                else if(rbtEmanetIslem.Checked == true)
                {
                    query = "Select * from emanetler Where EmanetIslemTarih between '" + reverseDate(mtbxStart.Text) + "' and '" + reverseDate(mtbxEnd.Text)+"'";
                }
                else if(rbtEmanetVerme.Checked == true)
                {
                    query = "Select * from Emanetler Where EmanetVermeTarih between '" + reverseDate(mtbxStart.Text) + "' and '" + reverseDate(mtbxEnd.Text) + "'";
                }
                else
                {
                    MessageBox.Show("Lütfen Seçenek Seçiniz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                DatabaseCrudHelper.GetList(dataGridView1, query);
            }
            catch(Exception exception)
            { 
                MessageBox.Show(exception.Message); 
            }
        }
    }
}
