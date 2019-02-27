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
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.IO;
using System.Data.OleDb;

namespace Yuz_Tanima_Sistemi
{
    public partial class anaForm : Form
    {

        //Degişken vektor ve haarcascades oluşturuluş yeri
        Image<Bgr, Byte> cerceve;
        Capture kamera;
        HaarCascade haarYolu;
        Image<Gray, byte> gri = null;
        List<Image<Gray, byte>> egitimResimler = new List<Image<Gray, byte>>();
        Image<Gray, byte> sonuc, egitilmisYuz = null;
        List<string> yazı = new List<string>();
        int yuzSayısı, sayiYazisi, t;
        //string name, names = null;

        public static string isim, soyisim, tc, kredi;
        public static int no, resimsayisi, yuresimNo;
        public static bool güncelle = false;


        //Acces baglantısı
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=yuzVeriTabani.accdb");

        public anaForm()
        {
            InitializeComponent();
            //haarcascade yolunu belirledik.
            haarYolu = new HaarCascade("haarcascade_frontalface_default.xml");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        byte tıksy = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Kamerayı Başlat")
            {
                if (tıksy == 0)
                {
                    //Cakera Başlatılma
                    kamera = new Capture();
                    kamera.QueryFrame();
                    //Gelen Verileri Frame Grabber'a gönderme
                    Application.Idle += new EventHandler(goruntuIsleme);
                    button4.Text = "Kamerayı Durdur";
                    tıksy = 1;
                }
                else
                {
                    Application.Idle += new EventHandler(goruntuIsleme);
                    button4.Text = "Kamerayı Durdur";
                }
            }
            else
            {
                Application.Idle -= new EventHandler(goruntuIsleme);
                button4.Text = "Kamerayı Başlat";
            }
        }
        void goruntuIsleme(object sender, EventArgs e)
        {

            //Resim Boyutunu islenecek boyuta çevirdi
            cerceve = kamera.QueryFrame().Resize(440, 330, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //resmi gri formata cevirdi
            gri = cerceve.Convert<Gray, Byte>();

            //Yuzu Bulma
            MCvAvgComp[][] facesDetected = gri.DetectHaarCascade(
          haarYolu,
          1.2,
          10,
          Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
          new Size(20, 20));

            //Tespit edilen elemanlar için eylemler
            foreach (MCvAvgComp f in facesDetected[0])
            {
                sonuc = cerceve.Copy(f.rect).Convert<Gray, byte>().Resize(500, 500, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //Yüzün çevresini çizme
                cerceve.Draw(f.rect, new Bgr(Color.Red), 2);
                //Bulunan yüz sayısı
                label6.Text = facesDetected[0].Length.ToString();
            }
            ımageBox1.Image = cerceve;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yeniKisiForm ykfrm = new yeniKisiForm();
            ykfrm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (güncelle == true)
            {
                kytBtn.Text = "Güncelle";
            }
            else
            {
                kytBtn.Text = "Kaydet";
            }
            isimTxt.Text = isim;
            soyisimTxt.Text = soyisim;
            tcnoTxt.Text = tc;
            krd_txt.Text = kredi;
        }
        int a = 1;
        int left = 0;
        int imageBoxsay = 10;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                label9.Text = a.ToString();
                gri = kamera.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                MCvAvgComp[][] facesDetected = gri.DetectHaarCascade(
                    haarYolu,
                    1.2,
                    10,
                    Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                    new Size(20, 20));
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    egitilmisYuz = cerceve.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }
                egitilmisYuz = sonuc.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                    try
                    {
                        panel1.AutoScroll = false;
                        Emgu.CV.UI.ImageBox imageBox = new Emgu.CV.UI.ImageBox();
                        imageBox.Height = 102;
                        imageBox.Width = 102;
                        imageBox.Top = -1;
                        imageBox.Left = left;
                        imageBoxsay++;
                        imageBox.Name = "yuzImg" + imageBoxsay;
                        imageBox.BorderStyle = BorderStyle.FixedSingle;
                        imageBox.Image = egitilmisYuz;
                        panel1.Controls.Add(imageBox);
                        OleDbCommand Countkomut = new OleDbCommand("Select Count(*) From veriTabani", baglanti);
                        baglanti.Open();
                        b = Convert.ToInt32(Countkomut.ExecuteScalar());
                        egitilmisYuz.ToBitmap().Save(Application.StartupPath + "/backimg/" + b + "_" + c + ".bmp");
                        label9.Text = c.ToString();
                        c++;
                        baglanti.Close();
                        
                    }
                    finally
                    {
                        left += 100;
                        panel1.AutoScroll = true;
                    }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            veriTabanındanCek vtcfrm = new veriTabanındanCek();
            vtcfrm.ShowDialog();
        }
        int b;
        int c = 1;
        private void kytBtn_Click(object sender, EventArgs e)
        {

            if (güncelle == true)
            {
                if (isimTxt.Text == "None" || isimTxt.Text == "" || isimTxt.Text == "None" || soyisimTxt.Text == "" || tcnoTxt.Text == "None" || tcnoTxt.Text == "")
                {
                    islemLbl.Text = "Bütün bölümleri doldurdugunuzdan emin olunuz.";
                }
                else
                {
                    try
                    {
                        c--;
                        for (int a = 1; a <= c; a++)
                        {
                            try
                            {
                                System.IO.File.Delete(Application.StartupPath + @"\yuzler\" + b + "_" + a + ".bmp");
                            }
                            catch { }
                            string sourceFile = Application.StartupPath + @"\backimg\" + b + "_" + a + ".bmp";
                            string destinationFile = Application.StartupPath + @"\yuzler\" + b + "_" + a + ".bmp";
                            DirectoryInfo di = new DirectoryInfo(Application.StartupPath + @"\backimg\");
                            System.IO.File.Move(sourceFile, destinationFile);
                        }
                        baglanti.Open();
                        OleDbCommand komut = new OleDbCommand("Update veriTabani set kisi_adi='" + isimTxt.Text + "', kisi_soyadi='" + soyisimTxt.Text + "', tc_no='" + tcnoTxt.Text + "',yuz_resimNo='" + yuresimNo + "', yuz_resimSayisi=" + c + ", kredi=" + kredi + " where Kimlik=" + no, baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        islemLbl.Text = "Kayıt işlemi başarılı";
                        panel1.Controls.Clear();
                        c = 1;
                        OleDbCommand Countkomut = new OleDbCommand("Select Count(*) From veriTabani", baglanti);
                        baglanti.Open();
                        b = Convert.ToInt32(Countkomut.ExecuteScalar()) + 1;
                        baglanti.Close();

                    }
                    catch (Exception ex)
                    {
                        islemLbl.Text = ex.Message;
                        baglanti.Close();
                        c = 1;
                    }
                }
                güncelle = false;
            }
            else
            {
                if (isimTxt.Text == "None" || isimTxt.Text == "" || isimTxt.Text == "None" || soyisimTxt.Text == "" || tcnoTxt.Text == "None" || tcnoTxt.Text == "")
                {
                    islemLbl.Text = "Bütün bölümleri doldurdugunuzdan emin olunuz.";
                }
                else
                {
                    try
                    {
                        c--;
                        for (int a = 1; a <= c; a++)
                        {
                            string sourceFile = Application.StartupPath + @"\backimg\" + b + "_" + a + ".bmp";
                            string destinationFile = Application.StartupPath + @"\yuzler\" + b + "_" + a + ".bmp";
                            DirectoryInfo di = new DirectoryInfo(Application.StartupPath + @"\backimg\");
                            System.IO.File.Move(sourceFile, destinationFile);
                        }
                        baglanti.Open();
                        OleDbCommand komut = new OleDbCommand("Insert Into veriTabani (kisi_adi,kisi_soyadi,tc_no,yuz_resimNo,yuz_resimSayisi,kredi) values ('" + isimTxt.Text + "','" + soyisimTxt.Text + "','" + tcnoTxt.Text + "','" + b + "','" + c + "','" + krd_txt.Text + "')", baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        islemLbl.Text = "Kayıt işlemi başarılı";
                        panel1.Controls.Clear();
                        c = 1;
                        OleDbCommand Countkomut = new OleDbCommand("Select Count(*) From veriTabani", baglanti);
                        baglanti.Open();
                        b = Convert.ToInt32(Countkomut.ExecuteScalar()) + 1;
                        güncelle = false;
                        baglanti.Close();

                    }
                    catch (Exception ex)
                    {
                        islemLbl.Text = ex.Message;
                        baglanti.Close();
                        c = 1;
                    }
                }
            }
        }
        DirectoryInfo di = new DirectoryInfo(Application.StartupPath + @"\backimg\");
        private void anaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kamera != null)
            {
                kamera.Dispose();
                islemLbl.Text = "Kamera objesi silindi.";
            }
            try
            {
                FileInfo[] rgFiles = di.GetFiles();
                foreach (FileInfo fi in rgFiles)
                {
                    islemLbl.Text ="Önbellekte olan" + fi.ToString() + "silindi.";
                    System.IO.File.Delete(Application.StartupPath + @"\backimg\" + fi.ToString());
                }
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        
      
    }
}
