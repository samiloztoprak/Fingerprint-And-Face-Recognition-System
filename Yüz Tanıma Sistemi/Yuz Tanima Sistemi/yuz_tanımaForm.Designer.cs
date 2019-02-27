namespace Yuz_Tanima_Sistemi
{
    partial class yuz_tanımaForm
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
            this.components = new System.ComponentModel.Container();
            this.ımageBox1 = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.yesilIsık = new System.Windows.Forms.PictureBox();
            this.kırmızıIsık = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.kırMik = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.yuzTanıma = new System.Windows.Forms.Timer(this.components);
            this.krdTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yesilIsık)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kırmızıIsık)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageBox1
            // 
            this.ımageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ımageBox1.Location = new System.Drawing.Point(12, 15);
            this.ımageBox1.Name = "ımageBox1";
            this.ımageBox1.Size = new System.Drawing.Size(320, 240);
            this.ımageBox1.TabIndex = 2;
            this.ımageBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(338, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adı  Soyadı   :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad.Location = new System.Drawing.Point(448, 15);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(0, 20);
            this.ad.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(230, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 28);
            this.button4.TabIndex = 12;
            this.button4.Text = "Kamerayı Başlat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(601, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 202);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(609, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 220);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // yesilIsık
            // 
            this.yesilIsık.BackColor = System.Drawing.Color.DarkGray;
            this.yesilIsık.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yesilIsık.Location = new System.Drawing.Point(625, 84);
            this.yesilIsık.Name = "yesilIsık";
            this.yesilIsık.Size = new System.Drawing.Size(100, 50);
            this.yesilIsık.TabIndex = 15;
            this.yesilIsık.TabStop = false;
            // 
            // kırmızıIsık
            // 
            this.kırmızıIsık.BackColor = System.Drawing.Color.DarkGray;
            this.kırmızıIsık.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kırmızıIsık.Location = new System.Drawing.Point(625, 140);
            this.kırmızıIsık.Name = "kırmızıIsık";
            this.kırmızıIsık.Size = new System.Drawing.Size(100, 50);
            this.kırmızıIsık.TabIndex = 16;
            this.kırmızıIsık.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(338, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kredi              :";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(381, 84);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(136, 127);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // kırMik
            // 
            this.kırMik.AutoSize = true;
            this.kırMik.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kırMik.Location = new System.Drawing.Point(422, 121);
            this.kırMik.Name = "kırMik";
            this.kırMik.Size = new System.Drawing.Size(51, 55);
            this.kırMik.TabIndex = 19;
            this.kırMik.Text = "0";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(688, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(625, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // yuzTanıma
            // 
            this.yuzTanıma.Tick += new System.EventHandler(this.yuzTanıma_Tick);
            // 
            // krdTxt
            // 
            this.krdTxt.AutoSize = true;
            this.krdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.krdTxt.Location = new System.Drawing.Point(448, 47);
            this.krdTxt.Name = "krdTxt";
            this.krdTxt.Size = new System.Drawing.Size(0, 20);
            this.krdTxt.TabIndex = 22;
            // 
            // yuz_tanımaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 285);
            this.Controls.Add(this.krdTxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kırMik);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kırmızıIsık);
            this.Controls.Add(this.yesilIsık);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ımageBox1);
            this.Name = "yuz_tanımaForm";
            this.Text = "yuz_tanımaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.yuz_tanımaForm_FormClosing);
            this.Load += new System.EventHandler(this.yuz_tanımaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yesilIsık)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kırmızıIsık)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox ımageBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox yesilIsık;
        private System.Windows.Forms.PictureBox kırmızıIsık;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label kırMik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer yuzTanıma;
        private System.Windows.Forms.Label krdTxt;
    }
}