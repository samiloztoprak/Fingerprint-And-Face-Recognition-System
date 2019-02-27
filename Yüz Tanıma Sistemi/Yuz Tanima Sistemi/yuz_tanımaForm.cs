using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Data.OleDb;
using System.IO;

namespace Yuz_Tanima_Sistemi
{
    public partial class yuz_tanımaForm : Form
    {
        public yuz_tanımaForm()
        {
            InitializeComponent();


            

            //haarcascade yolunu belirledik.
            haarYolu = new HaarCascade("haarcascade_frontalface_default.xml");

            OleDbCommand Countkomut = new OleDbCommand("Select Count(*) From veriTabani", baglanti);
            baglanti.Open();
            int b = Convert.ToInt32(Countkomut.ExecuteScalar());
            string[] kisiadi = new string[b];
            //string[] soyadi = new string[b];
            int dizino = 0;
            OleDbCommand veri = new OleDbCommand("SELECT Kimlik FROM veriTabani", baglanti);
            OleDbDataReader oku;
            oku = veri.ExecuteReader();//verileri cekme komutunu calıstırır
                while (oku.Read())
                {
                    kisiadi[dizino] = oku["Kimlik"].ToString();
                    dizino++;
                }
            oku.Close();
            //OleDbCommand veri2 = new OleDbCommand("SELECT kisi_soyadi FROM veriTabani", baglanti);
            //OleDbDataReader oku2;
            //oku2 = veri2.ExecuteReader();//verileri cekme komutunu calıstırır
            //dizino = 0;
            //    while (oku2.Read())
            //    {
            //        soyadi[dizino] = oku2["kisi_soyadi"].ToString();
            //        dizino++;
            //    }
            //oku2.Close();
            baglanti.Close();

            bmpsiralmasi=b.ToString()+"%";
            for (int tf = 0; tf < b; tf++)
            {
                try
                {
                    bmpsiralmasi = bmpsiralmasi + kisiadi[tf] /**+ " " + soyadi[tf]**/ + "%";
                }
                catch
                { }
            }
            string Labelsinfo = bmpsiralmasi;
            string[] Labels = Labelsinfo.Split('%');
            sayiYazisi = Convert.ToInt16(Labels[0]);
            yuzSayısı = sayiYazisi;
            string LoadFaces;
            for (int tf = 1; tf <= b; tf++)
            {
                try
                {
                    for (int td = 1; td <= 20; td++)
                    {
                        LoadFaces = tf + "_" + td + ".bmp";
                        egitimGoruntuleri.Add(new Image<Gray, byte>(Application.StartupPath + "/yuzler/" + LoadFaces));
                        yazı.Add(Labels[tf]);
                    }
                }
                catch(Exception ex) {
                    //MessageBox.Show("htata"+ex.Message);
                }

            }
        }

        Image<Bgr, Byte> cerceve;
        Capture kamera;
        HaarCascade haarYolu;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> gri = null;
        List<Image<Gray, byte>> egitimGoruntuleri = new List<Image<Gray, byte>>();
        Image<Gray, byte> sonuç, egitilmisYuz = null;
        List<string> yazı = new List<string>();
        int yuzSayısı, sayiYazisi, t;
        string Kimlik, isimler = null;
        List<string> kisiAdlari = new List<string>();
        //int yuzsayisi = Directory.GetFiles(Application.StartupPath, "*.bmp*", SearchOption.TopDirectoryOnly).Length;
        string bmpsiralmasi;
        //Acces baglantısı
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=yuzVeriTabani.accdb");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yuz_tanımaForm_Load(object sender, EventArgs e)
        {

        }

        byte tıksy = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (button4.Text == "Kamerayı Başlat")
                {
                    if (tıksy == 0)
                    {
                       
                        //Cakera Başlatılma
                        kamera = new Capture();
                        kamera.QueryFrame();
                        yuzTanıma.Enabled = true;
                        //Gelen Verileri Frame Grabber'a gönderme
                        Application.Idle += new EventHandler(goruntuIsleme);
                        button4.Text = "Kamerayı Durdur";
                        tıksy = 1;
                    }
                    else
                    {
                        
                        Application.Idle += new EventHandler(goruntuIsleme);
                        button4.Text = "Kamerayı Durdur";
                        yuzTanıma.Enabled = true;
                    }
                }
                else
                {
                    yuzTanıma.Enabled = false;
                    Application.Idle -= new EventHandler(goruntuIsleme);
                    button4.Text = "Kamerayı Başlat";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        MCvAvgComp[][] facesDetected;
        string eskisim = "";
        int eskikredi;
        void goruntuIsleme(object sender, EventArgs e)
        {

            //try
            //{
                //Resim Boyutunu islenecek boyuta çevirdi
                cerceve = kamera.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //resmi gri formata cevirdi
                gri = cerceve.Convert<Gray, Byte>();
                //Yuzu Bulma
                facesDetected = gri.DetectHaarCascade(
                haarYolu,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));
                ımageBox1.Image = cerceve;
                //Tespit edilen elemanlar için eylemler
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    sonuç = cerceve.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    //Yüzün çevresini çizme
                    cerceve.Draw(f.rect, new Bgr(Color.Red), 2);
                    //Bulunan yüz sayısı

                    if (egitimGoruntuleri.ToArray().Length != 0)
                    {
                        //TermCriteria for face recognition with numbers of trained images like maxIteration
                        MCvTermCriteria kritikNokta = new MCvTermCriteria(yuzSayısı, 0.001);
                        //Eigen face recognizer
                        EigenObjectRecognizer tanıyıcı = new EigenObjectRecognizer(
                           egitimGoruntuleri.ToArray(),
                           yazı.ToArray(),
                           3000,
                           ref kritikNokta);

                        Kimlik = tanıyıcı.Recognize(sonuç);

                        if (Kimlik != "")
                        {
                            OleDbCommand komut = new OleDbCommand("SELECT * FROM veriTabani WHERE Kimlik=" + Convert.ToInt32(Kimlik), baglanti);
                            baglanti.Open();
                            OleDbDataReader oku;
                            oku = komut.ExecuteReader();
                            while (oku.Read())
                            {
                                eskikredi =Convert.ToInt32(oku["kredi"]);
                                ad.Text = oku["kisi_adi"].ToString() + " " + oku["kisi_soyadi"].ToString();
                            }
                            if (ad.Text == eskisim)
                            { }
                            else
                            {
                                eskisim = ad.Text;
                                if (Convert.ToInt32(eskikredi) < 10)
                                {
                                    kırmızıIsık.BackColor = Color.Firebrick;
                                    yesilIsık.BackColor = Color.Black;
                                }
                                else
                                {
                                    yesilIsık.BackColor = Color.LightGreen;
                                    kırmızıIsık.BackColor = Color.Black;
                                    kırMik.Text = (eskikredi - 10).ToString();
                                    krdTxt.Text = eskikredi.ToString();
                                    OleDbCommand krdKomut = new OleDbCommand("Update veriTabani set kredi='" + kırMik.Text + "' where Kimlik=" + Convert.ToInt32(Kimlik), baglanti);
                                    krdKomut.ExecuteNonQuery();
                                }
                            }
                            baglanti.Close();
                        }
                    }
                    else
                    {
                        Kimlik = "";
                        kırmızıIsık.BackColor = Color.Firebrick;
                        yesilIsık.BackColor = Color.Black;
                    }

                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void yuz_tanımaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kamera != null)
                kamera.Dispose();
            Application.Exit();
        }

        private void yuzTanıma_Tick(object sender, EventArgs e)
        {
            
        }

    }
}
