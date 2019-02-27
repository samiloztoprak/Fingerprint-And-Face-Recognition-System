namespace Yuz_Tanima_Sistemi
{
    partial class anaForm
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
            this.ımageBox1 = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.krd_txt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.isimTxt = new System.Windows.Forms.Label();
            this.soyisimTxt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tcnoTxt = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kytBtn = new System.Windows.Forms.Button();
            this.islemLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageBox1
            // 
            this.ımageBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ımageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ımageBox1.Location = new System.Drawing.Point(12, 12);
            this.ımageBox1.Name = "ımageBox1";
            this.ımageBox1.Size = new System.Drawing.Size(430, 318);
            this.ımageBox1.TabIndex = 2;
            this.ımageBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Yeni Kullanıcı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(448, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi Yöntemi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 57);
            this.button2.TabIndex = 4;
            this.button2.Text = "Var \r\nOlan Kullanıcı";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "İsim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soyisim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tc No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resim Sayısı:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(448, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 45);
            this.button3.TabIndex = 11;
            this.button3.Text = "Yüzü Kes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.krd_txt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.isimTxt);
            this.groupBox2.Controls.Add(this.soyisimTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tcnoTxt);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(448, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 142);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgiler";
            // 
            // krd_txt
            // 
            this.krd_txt.AutoSize = true;
            this.krd_txt.Location = new System.Drawing.Point(82, 75);
            this.krd_txt.Name = "krd_txt";
            this.krd_txt.Size = new System.Drawing.Size(33, 13);
            this.krd_txt.TabIndex = 16;
            this.krd_txt.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kredi :";
            // 
            // isimTxt
            // 
            this.isimTxt.AutoSize = true;
            this.isimTxt.Location = new System.Drawing.Point(82, 36);
            this.isimTxt.Name = "isimTxt";
            this.isimTxt.Size = new System.Drawing.Size(33, 13);
            this.isimTxt.TabIndex = 11;
            this.isimTxt.Text = "None";
            // 
            // soyisimTxt
            // 
            this.soyisimTxt.AutoSize = true;
            this.soyisimTxt.Location = new System.Drawing.Point(82, 49);
            this.soyisimTxt.Name = "soyisimTxt";
            this.soyisimTxt.Size = new System.Drawing.Size(33, 13);
            this.soyisimTxt.TabIndex = 12;
            this.soyisimTxt.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "None";
            // 
            // tcnoTxt
            // 
            this.tcnoTxt.AutoSize = true;
            this.tcnoTxt.Location = new System.Drawing.Point(82, 62);
            this.tcnoTxt.Name = "tcnoTxt";
            this.tcnoTxt.Size = new System.Drawing.Size(33, 13);
            this.tcnoTxt.TabIndex = 13;
            this.tcnoTxt.Text = "None";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(144, 113);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Veriyi Çek";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(382, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 43);
            this.button4.TabIndex = 7;
            this.button4.Text = "Kamerayı Başlat";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 130);
            this.panel1.TabIndex = 15;
            // 
            // kytBtn
            // 
            this.kytBtn.Location = new System.Drawing.Point(565, 285);
            this.kytBtn.Name = "kytBtn";
            this.kytBtn.Size = new System.Drawing.Size(114, 45);
            this.kytBtn.TabIndex = 16;
            this.kytBtn.Text = "Kaydet";
            this.kytBtn.UseVisualStyleBackColor = true;
            this.kytBtn.Click += new System.EventHandler(this.kytBtn_Click);
            // 
            // islemLbl
            // 
            this.islemLbl.AutoSize = true;
            this.islemLbl.ForeColor = System.Drawing.Color.Maroon;
            this.islemLbl.Location = new System.Drawing.Point(12, 475);
            this.islemLbl.Name = "islemLbl";
            this.islemLbl.Size = new System.Drawing.Size(34, 13);
            this.islemLbl.TabIndex = 12;
            this.islemLbl.Text = "İslem:";
            // 
            // anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(687, 495);
            this.Controls.Add(this.islemLbl);
            this.Controls.Add(this.kytBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ımageBox1);
            this.Name = "anaForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.anaForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox ımageBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label isimTxt;
        public System.Windows.Forms.Label soyisimTxt;
        public System.Windows.Forms.Label tcnoTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kytBtn;
        private System.Windows.Forms.Label islemLbl;
        private System.Windows.Forms.Label krd_txt;
        private System.Windows.Forms.Label label7;

    }
}

