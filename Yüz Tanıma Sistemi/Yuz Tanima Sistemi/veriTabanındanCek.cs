using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Yuz_Tanima_Sistemi
{
    public partial class veriTabanındanCek : Form
    {
        public veriTabanındanCek()
        {
            InitializeComponent();
        }

        //Acces baglantısı
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=yuzVeriTabani.accdb");
        DataSet dtst = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();

        private void veriTabanındanCek_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From veriTabani", baglanti);
            adtr.Fill(dtst, "veriTabani");
            dataGridView1.DataSource = dtst.Tables["veriTabani"];
            adtr.Dispose();
            baglanti.Close();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (arKriteri.Text == "İsim" || arKriteri.Text == "Soyisim")
            {
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
            }
            else if (arKriteri.Text == "Tc Kimlik No"||arKriteri.Text == "Yüz Resim No"||arKriteri.Text == "Yüz Resim Sayısı")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }


            OleDbCommand komut = new OleDbCommand("SELECT *FROM veriTabani WHERE "+arKriteri.Text+" LIKE '"+textBox1.Text+"%'");
            komut.Connection = baglanti;
            adtr = new OleDbDataAdapter(komut);
            dtst = new DataSet();
            adtr.Fill(dtst, "tablo");
            dataGridView1.DataSource = dtst;
            dataGridView1.DataMember = "tablo";
            

        }

        private void secBtn_Click(object sender, EventArgs e)
        {
            anaForm.no = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            anaForm.isim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            anaForm.soyisim = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            anaForm.tc =dataGridView1.CurrentRow.Cells[3].Value.ToString();
            anaForm.yuresimNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            anaForm.resimsayisi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            anaForm.kredi = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            anaForm.güncelle = true;
           
            this.Hide();
        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            if (txt_adi.Text == "None" || txt_adi.Text == "" || txt_soyadi.Text == "None" || txt_soyadi.Text == "" || txt_tc.Text == "None" || txt_tc.Text == ""||txt_kredi==null)
            {
                textBox2.Text = textBox2.Text + "n/" + "Bütün bölümleri doldurdugunuzdan emin olunuz.";
            }
            else
            {
                try
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("Update veriTabani set kisi_adi='" + txt_adi.Text + "', kisi_soyadi='" + txt_soyadi.Text + "', tc_no='" + txt_tc.Text + "', kredi=" + txt_kredi.Text + " where Kimlik=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() , baglanti);
                    komut.ExecuteNonQuery();
                    textBox2.Text = textBox2.Text + "n/" + "Güncelleme işlemi başarılı";
                    dataGridView1.Columns.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("select * From veriTabani", baglanti);
                    adtr.Fill(dtst, "veriTabani");
                    dataGridView1.DataSource = dtst.Tables["veriTabani"];
                    adtr.Dispose();
                    dataGridView1.Refresh();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    textBox2.Text = textBox2.Text + "n/" + ex.Message;
                    baglanti.Close();
                }
            }
        }

        private void txt_adi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txt_soyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txt_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_kredi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_tc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kredi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

    }
}
