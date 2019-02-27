using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media; //Kinectten alınan resimleri ekrana görüntülemek için name space. 
using System.Windows.Media.Imaging;  //Kinectten alınan resimleri ekrana görüntülemek için name space.
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Kinect; //Kinect hakkında verilere ulaşmak için name space.
using System.IO.Ports; //Port ayarlarını yapmak için name space.
using Microsoft.Runtime.Hosting; //Kinecti çalıştırmak için name space.
using System.Threading; //Kinectten görüntü almak için name space.

namespace Sandalyatakipsistemi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region oluşturulan degişken ve nesneler
        //Seri port nesnesini oluşturduk.
        SerialPort serialPort = new SerialPort();

        // Tüm tanımlanan iskeletlere ait veriyi tutacak iskelet dizisi
        private Skeleton[] skeletons = new Skeleton[6];

        // Takip edilecek ve işlenecek iskelet
        private Skeleton skeleton;

        //Kinecti çalıştırmak için kinect nesnesini oluşturduk.
        private KinectSensor kinect;
        private byte[] pixelData;

        // Image elementinin kaynağı olarak atanacak görüntü:
        private WriteableBitmap outputImage;

        //Ekrana renkli görüntü getirmek içn Color İmage nesnesi oluşturduk.
        private ColorImageFormat lastImageFormat = ColorImageFormat.Undefined;
        #endregion
        string tekerposition;
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            #region timer oluşturma
            //Timerı oluşturur.
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(timer_tick1);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Start();
            #endregion

            #region seriportoluşturma
            string[] seriport = SerialPort.GetPortNames();
            foreach (string a in seriport)
            {
                combobox.Items.Add(a);
            }
            try
            {
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.ReadTimeout = 2000;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex);
            }
            #endregion

            

            #region kinect işlemleri
            // Kinect bağlıysa, belirtilen parametrelere göre ilk Kinect'i yapılandır ve başlat
            if (KinectSensor.KinectSensors.Count > 0)
            {
                try
                {
                    kinect = KinectSensor.KinectSensors[0];

                    // Hareket yumuşatma parametreleri
                    TransformSmoothParameters tsp = new TransformSmoothParameters();
                    tsp.Smoothing = 0.55f;
                    tsp.Correction = 0.1f;
                    tsp.Prediction = 0.1f;
                    tsp.JitterRadius = 0.4f;
                    tsp.MaxDeviationRadius = 0.4f;

                    // Kinect'i başlat
                    kinect.Start();

                    motor.Value = kinect.ElevationAngle;
                    kinect.SkeletonStream.TrackingMode = SkeletonTrackingMode.Seated;
                    // Kinect'in renkli görüntü akışını RGB 640x480 30fps biçiminde başlat:
                    KinectSensor.KinectSensors[0].ColorStream.Enable
                        (ColorImageFormat.YuvResolution640x480Fps15);

                    // Yeni görüntü geldiğinde tetiklenecek event handler'ı oluştur
                    KinectSensor.KinectSensors[0].ColorFrameReady
                         += new EventHandler<ColorImageFrameReadyEventArgs>(Kinect_ColorFrameReady);

                    // İskelet verisi akışını belirtilen hareket yumuşatma parametrelerine göre başlat
                    KinectSensor.KinectSensors[0].SkeletonStream.Enable(tsp);

                    // İskelet verisi güncellendiğinde tetiklenecek eventi oluştur
                    KinectSensor.KinectSensors[0].SkeletonFrameReady
                        += new EventHandler<SkeletonFrameReadyEventArgs>(Kinect_SkeletonFrameReady);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kinect başlatılırken hata oluştu." + ex.Message);
                }
            }
            #endregion

        }

        private void Kinect_ColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        {
            // Derinlik bilgisini açıp depthFrame'e aktar
            using (ColorImageFrame imageFrame = e.OpenColorImageFrame())
            {
                if (imageFrame != null)
                {
                    // Önceki görüntü biçimi ile yeni gelen görüntü biçimi farklı mı?
                    bool haveNewFormat = lastImageFormat != imageFrame.Format;

                    // Görüntü biçimi değiştiyse:
                    if (haveNewFormat)
                    {
                        // Yeni görüntü boyutuna göre pixelData dizisini boyutlandır:
                        pixelData = new byte[imageFrame.PixelDataLength];
                    }

                    // Görüntüyü pixelData dizisine aktar:
                    imageFrame.CopyPixelDataTo(pixelData);

                    // Görüntü biçimi değiştiyse:
                    if (haveNewFormat)
                    {
                        // Image elementinin kaynağı olarak gösterilen outputImage'ın
                        // özelliklerini değiştir:
                        outputImage = new WriteableBitmap(
                            imageFrame.Width,  // Genişlik
                            imageFrame.Height, // Yükseklik
                            96,  // Yatay DPI
                            96,  // Dikey DPI
                            PixelFormats.Bgr32, // Piksel biçimi
                            null); // Bitmap paleti

                        // Image elementinin kaynağını outputImage olarak belirle:
                        imgColorFrame.Source = outputImage;
                    }

                    // outputImage'ın içeriğini güncelle:
                    outputImage.WritePixels(
                        new Int32Rect(0, 0, imageFrame.Width, imageFrame.Height),
                        pixelData,
                        imageFrame.Width * 4,
                        0);

                    // Bir sonraki görüntü biçimi karşılaştırması için, yeni görüntü
                    // biçimini kaydet:
                    lastImageFormat = imageFrame.Format;
                }
            }
        }


        private void Kinect_SkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            try
            {
                // Gelen iskelet verisini skeletons dizisine kopyala
                if (e.OpenSkeletonFrame() != null) e.OpenSkeletonFrame().CopySkeletonDataTo(skeletons);

                // İlk algılanan iskeleti seç
                skeleton = (from s in skeletons
                            where s.TrackingState == SkeletonTrackingState.Tracked
                            select s).FirstOrDefault();
                
            }
            catch (Exception)
            {
                // Hata oluşursa skeleton'un parametrelerini temizle.
                // Bu frame'de veri işlemesi yapmayacağız.
                skeleton = null;
            }
            if (skeleton != null)
            {
                // İskelet yapısını göster:
                EklemGoster(skeleton);
            }
        }

        double mesafe;
        private void EklemGoster(Skeleton skeleton)
        {
            // Elipsleri, ilgili iskelet parametrelerine göre konumlandır:
            ElipsKonumlandir(elpBas, skeleton.Joints[JointType.Head]);
            ElipsKonumlandir(elpBoyun, skeleton.Joints[JointType.ShoulderCenter]);
            ElipsKonumlandir(elpSolEl, skeleton.Joints[JointType.ShoulderLeft]);
            ElipsKonumlandir(elpSagEl, skeleton.Joints[JointType.ShoulderRight]);
            tbPixelDistance.Text = (skeleton.Joints[JointType.ShoulderCenter].Position.Z).ToString("0m.00cm");
            mesafe = skeleton.Joints[JointType.ShoulderCenter].Position.Z;
        }

        private void ElipsKonumlandir(FrameworkElement ellipse, Joint joint)
        {
            try
            {
                //Ellipse'in canvas'ın sol ve üst kenarından uzaklığı.
                Canvas.SetLeft(ellipse, (joint.Position.X + 1) * 217);
                Canvas.SetTop(ellipse, (480 - (joint.Position.Y + 1) * 300));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                MessageBox.Show("Seri port kapatılıyor");
            }
            try
            {
                // Kinect çalışıyorsa durdur
                if (kinect != null && kinect.IsRunning)
                {
                    kinect.ElevationAngle = 0;
                    kinect.Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kinect konumlandırılırken hata oluştu.\n"+ex.Message,"Hata");
            }
        }

        private void baglan_Click(object sender, RoutedEventArgs e)
        {
            portaçmakapamametodu();
        }

        public void portaçmakapamametodu()
        {
            try
            {
                if (combobox.Text != "")
                {
                    if (serialPort.IsOpen)
                    {
                        serialPort.Close();
                        baglan.Content = "Baglan";
                        MessageBox.Show("Açık kalan seri port kapatıldı.\nAçmak için bir daha tıklayın.");
                    }
                    else
                    {
                        serialPort.PortName = combobox.Text;
                        serialPort.Open();
                        baglan.Content = "Kapat";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex);
            }
        }

        private void motor_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                kinect.ElevationAngle = Convert.ToInt16(motor.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Konumlandırmada hata oluştu.\n"+ex.Message,"Hata");
            }
        }

        string durum=null;
        private void timer_tick1(object sender, EventArgs e)
        {



            if (tekerposition == null & serialPort.IsOpen)
            {
                serialPort.WriteLine("1\n");
                serialPort.WriteLine("1\n");
                serialPort.WriteLine("1\n");
                serialPort.WriteLine("1\n");
                serialPort.WriteLine("1\n");
                serialPort.WriteLine("1\n");
                tekerposition = "sol";
            }

            if (skeleton != null)
            {
                yukleniyor.Visibility = Visibility.Hidden;
                if (serialPort.IsOpen)
                {
                    try
                    {
                        int a = Convert.ToInt16(Canvas.GetLeft(elpBoyun));
                        if ((a > (cnvSkeleton.Width / 2 + 20)) & (durum!="dur"))
                        {
                            ilerigerihareket.Text = "Sola git komutu gönderildi.\n" + ilerigerihareket.Text;
                            serialPort.WriteLine("1\n");

                            if (tekerposition == "sag")
                            {
                                tekerposition = "orta";
                            }
                            else
                            {
                                tekerposition = "sol";
                            }
                            seriportokunan.Text = "Seri porta gönderilen veri= 1\n" + seriportokunan.Text;
                        }
                        else if ((a < (cnvSkeleton.Width / 2 - 20)) & (durum != "dur"))
                        {
                            ilerigerihareket.Text = "Saga git komutu gönderildi.\n" + ilerigerihareket.Text;
                            serialPort.WriteLine("2\n");
                            if (tekerposition == "sol")
                            {
                                tekerposition = "orta";
                            }
                            else
                            {
                                tekerposition = "sag";
                            }
                            seriportokunan.Text = "Seri porta gönderilen veri= 2\n" + seriportokunan.Text;
                        }
                        else
                        {
                            if (tekerposition == "sag")
                            {
                                serialPort.Write("1\n");
                                tekerposition = "orta";
                            }
                            else if (tekerposition == "sol")
                            {
                                serialPort.Write("2\n");
                                tekerposition = "orta";
                            }
                        }
                      }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Yön Hatası\nHata:\n" + ex.Message);
                    }

                    try
                    {
                        if (mesafe > 1.40)
                        {
                            ilerigerihareket.Text = "İleri git komutu gönderildi.\n" + ilerigerihareket.Text;
                            serialPort.WriteLine("i\n");
                            seriportokunan.Text = "Seri porta gönderilen veri= i\n" + seriportokunan.Text;

                            durum = "ileri";
                        }
                        else if (mesafe < 1.10)
                        {
                            ilerigerihareket.Text = "Geri git komutu gönderildi.\n" + ilerigerihareket.Text;
                            serialPort.WriteLine("g\n");
                            seriportokunan.Text = "Seri porta gönderilen veri= g\n" + seriportokunan.Text;

                            durum = "geri";
                        }
                        else
                        {

                            if (durum != "dur")
                            {
                                if (tekerposition == "sag")
                                {
                                    serialPort.Write("1\n");
                                    tekerposition = "orta";
                                }
                                else if (tekerposition == "sol")
                                {
                                    serialPort.Write("2\n");
                                    tekerposition = "orta";
                                }
                                ilerigerihareket.Text = "Şahıs durdu. Yanaşılıyor.\n" + ilerigerihareket.Text;

                                ilerigerihareket.Text = "Yanaşmak için ileri git komutu gönderildi.\n" + ilerigerihareket.Text;
                                serialPort.WriteLine("y\n");
                                seriportokunan.Text = seriportokunan.Text + "Seri porta gönderilen veri= i\n";
                                durum = "dur";
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("İleriGeri hareket hatası\nHata:\n" + ex.Message);
                    }
                }

            }
            else
            {
                yukleniyor.Visibility = Visibility.Visible;
            }
            
            



            }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                kinect.ElevationAngle = 0;
                motor.Value = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kinecti konumlandırırken hata oluştu.\n"+ex.Message);
            }
        }


        private void temizle_Click(object sender, RoutedEventArgs e)
        {
            seriportokunan.Clear();
        }

        private void temizle2_Click(object sender, RoutedEventArgs e)
        {
            ilerigerihareket.Clear();
        }   
    }
}