using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orman_Takip_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int MenuAlani = 30;
        bool TasimaKontrol;
        Point IlkKonum;
        //float enlem, boylam;
        public void Boyutlandirma()
        {
            int yatay = this.Width;
            int dikey = this.Width;
            pnlMenu.Left = 0;
            pnlMenu.Top = 20;
            pnlMenu.Height = dikey;
            pnlMenu.Width = (yatay / 100 * MenuAlani);
            pnlHarita.Top = 0;
            pnlHarita.Left = (pnlMenu.Location.X + pnlMenu.Width + 1);
            //pnlHarita.Height = dikey;
            pnlHarita.Width = (yatay / 100 * (100-MenuAlani))+65;
            btnMenuGenislik.Top = 0;
            btnMenuGenislik.Height = dikey;
            btnMenuGenislik.Width = 2;
            btnMenuGenislik.Left = pnlMenu.Left + pnlMenu.Width;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            splash spl = new splash();
            this.Hide();
            spl.Show();
            Boyutlandirma();
            pnlHarita.BackColor = Color.FromArgb(150, 20, 25, 29);
            //pnlHarita.BackColor = Color.FromArgb(150, 75, 106, 110);
            pnlMenu.BackColor = Color.FromArgb(150, 76, 76, 76);
            tabPage1.BackColor = Color.FromArgb(150, 76, 76, 76);
            tabPage2.BackColor = Color.FromArgb(150, 76, 76, 76);
            btnMenuGenislik.BackColor = Color.FromArgb(150, 73, 84, 94);
            btnMenuGenislik.ForeColor = Color.FromArgb(150, 73, 84, 94);
            ustMenu.BackColor = Color.FromArgb(150, 99, 99, 99);
            ustMenu.ForeColor = Color.FromArgb(150, 221, 221, 221);
            kontrol.BackColor = Color.FromArgb(150, 55, 80, 104);

            //groubBox1.BackColor = Color.FromArgb(20, 20, 20);
            //groubBox1.ForeColor = Color.FromArgb(228, 235, 244);
            #region Harita alanı oluşturma
            int k = 1;
            for (int i = 0; i < 1680; i = i + 42)
            {
                for (int j = 22; j < 866; j = j + 42)
                {
                    PictureBox picture8 = new PictureBox();
                    picture8.SetBounds(i, j, 40, 40);//location ve size belirleme
                    picture8.Image = Image.FromFile("C:\\Users\\samil\\Documents\\visual studio 2015\\Projects\\Orman Takip Programı\\Orman Takip Programı\\Resources\\asdf.png");
                    pnlHarita.Controls.Add(picture8);
                    picture8.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture8.Tag = "picture" + k;
                    //picture8.BackColor = Color.FromArgb(255, 226, 132, 0);
                    k++;
                }
            }
            //PictureBox picture = new PictureBox();
            //picture.SetBounds(0, 22, 40, 40);//location ve size belirleme
            //pnlHarita.Controls.Add(picture);
            //picture.BackColor = Color.FromArgb(255,226,132,0);
            //PictureBox picture2 = new PictureBox();
            //picture2.SetBounds(0, 64, 40, 40);//location ve size belirleme
            //pnlHarita.Controls.Add(picture2);
            //picture2.BackColor = Color.FromArgb(255, 226, 132, 0);
            //PictureBox picture3 = new PictureBox();
            //picture3.SetBounds(0, 106, 40, 40);//location ve size belirleme
            //pnlHarita.Controls.Add(picture3);
            //picture3.BackColor = Color.FromArgb(255, 226, 132, 0);

            #endregion
            this.Show();
            spl.Hide();
        }
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Boyutlandirma();
        }

        private void btnMenuGenislik_MouseDown(object sender, MouseEventArgs e)
        {
            TasimaKontrol = true;
            IlkKonum = e.Location;

        }

        private void btnMenuGenislik_MouseMove(object sender, MouseEventArgs e)
        {
            if (TasimaKontrol)
            {
                btnMenuGenislik.Left = e.X + btnMenuGenislik.Left - (IlkKonum.X);
                #region hesaplama
                MenuAlani = 100 - (((this.Width - btnMenuGenislik.Left) * 100) / this.Width);

                label1.Text = MenuAlani.ToString() + "--" + this.Width + "--" + pnlMenu.Width + "\n" + (this.Width - btnMenuGenislik.Left);
                #endregion

            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenuGenislik_MouseUp(object sender, MouseEventArgs e)
        {
            Boyutlandirma();
            TasimaKontrol = false;
        }
    }
}
