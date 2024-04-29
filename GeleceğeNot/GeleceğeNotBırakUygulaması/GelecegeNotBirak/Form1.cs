using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin; 
using MaterialSkin.Controls;
using Npgsql;

namespace GelecegeNotBirak
{
    public partial class Form1 : MaterialForm //Form1'i MaterialForm olarak daha estetik olması için değiştirdim
    {
     
        private NpgsqlConnection connection;  // PostgreSQL bağlantı nesnesi

        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=nergis;Database=notlar"; // PostgreSql veri tabanı bağlantısı için gerekli bağlantı dizesi
        public Form1()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
      
        }
        private void InitializeDatabaseConnection()
        {
            connection = new NpgsqlConnection(connectionString);
        }
        private void Form1_Load(object sender, EventArgs e)
   
        {
            //MaterialSkin kütüphanesi ile formu daha estetik hale getirmek için renk ayarıyla düzenledim.
            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.DARK;
            msm.ColorScheme = new ColorScheme(Primary.Pink900, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Blue700, TextShade.BLACK);

        }


        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        // Form2'yi açar.
        private void OpenForm2()
        {
            form2 form2 = new form2(connection); // Form2'yi bağlantı nesnesi ile oluşturduk
            form2.Show(); // Form2'yi gösterir.

        }
        // "buton_giris" butonuna tıklandığında yapılacak işlemler;
        private void buton_giris_Click(object sender, EventArgs e)
        { 
            // Kullanıcı adını ve şifreyi text kutularından alın
            string kullaniciAdi = textbox_kullanici_giris.Text;
            string sifre = textbox_sifre_giris.Text;

            // Kullanıcı adı veya şifre boş mu diye kontrol eder.
            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifreyi giriniz.");
                return;
            }

            try
            {
                // Bağlantıyı açar.
                connection.Open();

                // Veritabanında kullanıcı adı ve şifreyi kontrol eden bir sorgu oluşturur. Parametre olarak @kullanıcıAdi @sifre alır.
                string sorgu = "SELECT COUNT(*) FROM uye WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre";
                using (NpgsqlCommand komut = new NpgsqlCommand(sorgu, connection))
                {
                    komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@sifre", sifre);

                    // Sorguyu çalıştırıp sonucu alın
                    int kullaniciSayisi = Convert.ToInt32(komut.ExecuteScalar());

                    // Kullanıcı varsa Form2'yi açar, yoksa MessageBox ile hata mesajı gösterir.
                    if (kullaniciSayisi > 0)
                    {
                        OpenForm2(); // Form2'yi açar.
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz kullanıcı adı veya şifre.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatır.
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            // Kullanıcı adını ve şifreyi textBox'daki ilgili alanlardan alır.
            string kullaniciAdi = textbox_kullanici_adi.Text;
            string sifre = textbox_sifre.Text;

            // Kullanıcı adı veya şifre boş mu diye kontrol eder.
            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifreyi giriniz.");
                return;
            }

            try
            {
                // Bağlantıyı açar.
                connection.Open();

                // Veritabanına veri eklemek için bir komut oluşturuyoruz.
                string sorgu = "INSERT INTO uye (kullanici_adi, sifre) VALUES (@kullaniciAdi, @sifre)";
                using (NpgsqlCommand komut = new NpgsqlCommand(sorgu, connection))
                {
                    komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@sifre", sifre);

                    // Komutu çalıştırır.
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kullanıcı başarıyla kaydedildi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatın
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void textbox_sifre_Click(object sender, EventArgs e)
        {

        }
        // Kullanıcı şifre girişinin güvenlik için daha sağlıklı olması adına göster/gizle eklendi
        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox1.Checked)
            {
                textbox_sifre_giris.PasswordChar = '\0'; // Metni düz metin olarak göster
                materialCheckBox1.Text = "Gizle";
            }
            else
            {
                textbox_sifre_giris.PasswordChar = '*'; // Şifre olarak göster (* karakterleri ile)
                materialCheckBox1.Text = "Göster";
            }
        }

        private void materialCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            

            if (materialCheckBox2.Checked)
            {
                textbox_sifre.PasswordChar = '\0'; // Metni düz metin olarak göster
                materialCheckBox2.Text = "Gizle";

            }
            else
            {
                textbox_sifre.PasswordChar = '*'; //Şifre olarak göster (* karakterleri ile)
                materialCheckBox2.Text = "Göster";
            }



        }
       

    }
}
