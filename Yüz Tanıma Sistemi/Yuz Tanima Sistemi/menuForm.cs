using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yuz_Tanima_Sistemi
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sifreKontrol anafrm = new sifreKontrol();
            this.Hide();
            anafrm.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yuz_tanımaForm ytfrm = new yuz_tanımaForm();
            this.Hide();
            ytfrm.Show();
        }

    }
}
