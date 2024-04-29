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

using System.Timers;


namespace GelecegeNotBirak
{
    public partial class form2 : MaterialForm  //Form2 yi MaterialForm olarak daha estetik olması için değiştirdim
    {
        private NpgsqlConnection connection; // PostgreSQL bağlantı nesnesi

      
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=nergis;Database=notlar";  // PostgreSql veri tabanı bağlantısı için gerekli bağlantı dizesi
        // PostgreSQL bağlantı nesnesini alan bir yapıcı metot oluşturduk.
        private System.Timers.Timer timer;

        public form2(NpgsqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection; // PostgreSQL bağlantı nesnesini ayarladık
            
        }

    
        private System.Windows.Forms.Timer countdownTimer; //Timer sınıfından bir örnek oluşturduk
       //Bu zamanlayıcı nesnesi belirli aralıklarla bir olayı tetikleyerek zamanlayıcı işlevselliği sağlar.


        private int remainingSeconds; //geri sayım süresini saklamak için bir tam sayı değişkeni (int) tanımladık.


        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeTimer(); // Timer nesnesini oluşturmak için bu metodu çağırdık.




           //MaterialSkin kütüphanesi ile formu daha estetik hale getirmek için renk ayarıyla düzenledim.

            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.DARK;
            msm.ColorScheme = new ColorScheme(Primary.Pink900, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Blue700, TextShade.BLACK);
            text_notlar.Size = new System.Drawing.Size(300, 40);


            InitializeCountdownTimer();

            RetrieveFutureNotes(); // Notları gösteriyor.
        }

        // Timer bileşenini başlatan metot
        private void InitializeCountdownTimer()
        {
            countdownTimer = new System.Windows.Forms.Timer(); //Zamanlayıcıdır ve belirli aralıklarla bir olayı tetiklemek için kullanılır.
            countdownTimer.Interval = 1000; // Zamanlayıcı her 1 saniyede bir tetiklenecektir.

        }

        // Dakika seçimi yapıldığında geri sayımı başlatan olay


        private void StartCountdown()
        {
            countdownTimer.Start(); // Geri sayımı başlatır.

        }

        // Notu gösteren metot
        private void ShowNote()
        {
            // Notu gösterme işlemleri;
            MessageBox.Show("Notunuz gösterildi!");
        }

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000; //  bir kontrol etmek için
            timer.Elapsed += OnTimedEvent;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                RetrieveFutureNotes();
            });
        }
        private void RetrieveFutureNotes()
        {
            try
            {
                listBox1.Items.Clear(); // ListBox'u temizle

                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    // Gelecekteki notları zamanı geldiğinde göstermek için sorguyu oluşturun
                    string sorgu = "SELECT note, display_date FROM notlar WHERE display_date  <= CURRENT_TIMESTAMP";


                    using (NpgsqlCommand komut = new NpgsqlCommand(sorgu, conn))
                    {
                        using (NpgsqlDataReader okuyucu = komut.ExecuteReader())
                        {
                            while (okuyucu.Read())
                            {
                                DateTime ekranTarihi = Convert.ToDateTime(okuyucu["display_date"]);
                                if (ekranTarihi <= DateTime.Now)
                                {
                                    // ListBox'a notları ekliyor.
                                    string notMetni = $" - {okuyucu["note"]} - {ekranTarihi.ToString("dd.MM.yyyy HH:mm")}";
                                    listBox1.Items.Add(notMetni);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string not = text_notlar.Text;
            DateTime displayDateTime = dateTimePicker1.Value;

            

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO notlar (note, display_date) VALUES (@not, @displayDateTime)";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@not", not);
                        command.Parameters.AddWithValue("@displayDateTime", displayDateTime);
                   

                        int rowsAffected = command.ExecuteNonQuery();  // sorguyu çalıştır, etkilenen satır sayısını alır.
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Not başarıyla kaydedildi.");
                            RetrieveUserNotes(); // Yeni not eklendikten sonra kullanıcı notlarını güncelle

                            

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        public class Note
        {
            public int Id { get; set; }
            public string Not { get; set; }
            public DateTime DisplayDate { get; set; }
            public DateTime CreatedAt { get; set; }

            
        }

        private void RetrieveUserNotes()
        {
            try
            {
                listBox1.Items.Clear(); // ListBox'u temizle

                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string sorgu = "SELECT note, display_date FROM notlar WHERE display_date <= CURRENT_TIMESTAMP";

                    using (NpgsqlCommand komut = new NpgsqlCommand(sorgu, conn))
                    {
                      


                        using (NpgsqlDataReader okuyucu = komut.ExecuteReader())
                        {
                            while (okuyucu.Read())
                            {
                                DateTime ekranTarihi = Convert.ToDateTime(okuyucu["display_date"]);
                                if (ekranTarihi <= DateTime.Now)
                                {
                                    // ListBox'a notları ekleyin
                                    string notMetni = $"{okuyucu["note"]} - {ekranTarihi.ToString("dd.MM.yyyy HH:mm")}";
                                    listBox1.Items.Add(notMetni);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
           RetrieveUserNotes();
        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}


