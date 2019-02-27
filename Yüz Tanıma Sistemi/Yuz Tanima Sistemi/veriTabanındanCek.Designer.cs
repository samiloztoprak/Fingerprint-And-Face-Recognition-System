namespace Yuz_Tanima_Sistemi
{
    partial class veriTabanındanCek
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arKriteri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Güncelle = new System.Windows.Forms.Button();
            this.txt_kredi = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 327);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // arKriteri
            // 
            this.arKriteri.FormattingEnabled = true;
            this.arKriteri.Items.AddRange(new object[] {
            "kisi_adi",
            "kisi_soyisim",
            "tc_no",
            "yuz_resimNo",
            "yuz_resimSayisi",
            "kredi"});
            this.arKriteri.Location = new System.Drawing.Point(12, 30);
            this.arKriteri.Name = "arKriteri";
            this.arKriteri.Size = new System.Drawing.Size(121, 21);
            this.arKriteri.TabIndex = 1;
            this.arKriteri.Text = "kisi_adi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama Kriteri";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aranacak Bilgi";
            // 
            // secBtn
            // 
            this.secBtn.Location = new System.Drawing.Point(279, 27);
            this.secBtn.Name = "secBtn";
            this.secBtn.Size = new System.Drawing.Size(204, 23);
            this.secBtn.TabIndex = 7;
            this.secBtn.Text = "Seç";
            this.secBtn.UseVisualStyleBackColor = true;
            this.secBtn.Click += new System.EventHandler(this.secBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Güncelle);
            this.groupBox1.Controls.Add(this.txt_kredi);
            this.groupBox1.Controls.Add(this.txt_tc);
            this.groupBox1.Controls.Add(this.txt_soyadi);
            this.groupBox1.Controls.Add(this.txt_adi);
            this.groupBox1.Location = new System.Drawing.Point(489, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 164);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güncelle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kredi     :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tc No   :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Soyisim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "İsim       :";
            // 
            // Güncelle
            // 
            this.Güncelle.Location = new System.Drawing.Point(6, 123);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(152, 33);
            this.Güncelle.TabIndex = 4;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = true;
            this.Güncelle.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // txt_kredi
            // 
            this.txt_kredi.Location = new System.Drawing.Point(58, 97);
            this.txt_kredi.Name = "txt_kredi";
            this.txt_kredi.Size = new System.Drawing.Size(100, 20);
            this.txt_kredi.TabIndex = 3;
            this.txt_kredi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kredi_KeyPress);
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(58, 71);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(100, 20);
            this.txt_tc.TabIndex = 2;
            this.txt_tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tc_KeyPress);
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Location = new System.Drawing.Point(58, 45);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(100, 20);
            this.txt_soyadi.TabIndex = 1;
            this.txt_soyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soyadi_KeyPress);
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(58, 19);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(100, 20);
            this.txt_adi.TabIndex = 0;
            this.txt_adi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_adi_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2.Location = new System.Drawing.Point(489, 200);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 184);
            this.textBox2.TabIndex = 9;
            // 
            // veriTabanındanCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 398);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.secBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arKriteri);
            this.Controls.Add(this.dataGridView1);
            this.Name = "veriTabanındanCek";
            this.Text = "Güncelle Formu";
            this.Load += new System.EventHandler(this.veriTabanındanCek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox arKriteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button secBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.TextBox txt_kredi;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.TextBox textBox2;
    }
}