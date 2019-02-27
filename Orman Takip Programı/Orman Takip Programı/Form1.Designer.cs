namespace Orman_Takip_Programı
{
    partial class Form1
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnMenuGenislik = new System.Windows.Forms.Button();
            this.ustMenu = new System.Windows.Forms.MenuStrip();
            this.kontrol = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrol1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrol2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.denemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deneme1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deneme2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHarita = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ustMenu.SuspendLayout();
            this.pnlHarita.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMenu.Controls.Add(this.tabControl1);
            this.pnlMenu.Location = new System.Drawing.Point(0, 24);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(300, 410);
            this.pnlMenu.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(273, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ağaç Bilgi Düzenleme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(273, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yeni Ağaç Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnMenuGenislik
            // 
            this.btnMenuGenislik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMenuGenislik.BackColor = System.Drawing.Color.Gray;
            this.btnMenuGenislik.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.btnMenuGenislik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuGenislik.ForeColor = System.Drawing.Color.Gray;
            this.btnMenuGenislik.Location = new System.Drawing.Point(294, 0);
            this.btnMenuGenislik.Name = "btnMenuGenislik";
            this.btnMenuGenislik.Size = new System.Drawing.Size(10, 434);
            this.btnMenuGenislik.TabIndex = 0;
            this.btnMenuGenislik.UseVisualStyleBackColor = false;
            this.btnMenuGenislik.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMenuGenislik_MouseDown);
            this.btnMenuGenislik.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMenuGenislik_MouseMove);
            this.btnMenuGenislik.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMenuGenislik_MouseUp);
            // 
            // ustMenu
            // 
            this.ustMenu.BackColor = System.Drawing.Color.White;
            this.ustMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontrol,
            this.denemeToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.ustMenu.Location = new System.Drawing.Point(0, 0);
            this.ustMenu.Name = "ustMenu";
            this.ustMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ustMenu.Size = new System.Drawing.Size(883, 29);
            this.ustMenu.TabIndex = 2;
            this.ustMenu.Text = "menuStrip1";
            // 
            // kontrol
            // 
            this.kontrol.BackColor = System.Drawing.Color.Transparent;
            this.kontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kontrol.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontrol1ToolStripMenuItem,
            this.kontrol2ToolStripMenuItem});
            this.kontrol.ForeColor = System.Drawing.Color.Silver;
            this.kontrol.Name = "kontrol";
            this.kontrol.Size = new System.Drawing.Size(71, 25);
            this.kontrol.Text = "Kontroller";
            this.kontrol.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // kontrol1ToolStripMenuItem
            // 
            this.kontrol1ToolStripMenuItem.Name = "kontrol1ToolStripMenuItem";
            this.kontrol1ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.kontrol1ToolStripMenuItem.Text = "Kontrol-1";
            // 
            // kontrol2ToolStripMenuItem
            // 
            this.kontrol2ToolStripMenuItem.Name = "kontrol2ToolStripMenuItem";
            this.kontrol2ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.kontrol2ToolStripMenuItem.Text = "Kontrol-2";
            // 
            // denemeToolStripMenuItem
            // 
            this.denemeToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.denemeToolStripMenuItem.BackgroundImage = global::Orman_Takip_Programı.Properties.Resources.button;
            this.denemeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.denemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deneme1ToolStripMenuItem,
            this.deneme2ToolStripMenuItem});
            this.denemeToolStripMenuItem.Name = "denemeToolStripMenuItem";
            this.denemeToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.denemeToolStripMenuItem.Text = "Deneme";
            // 
            // deneme1ToolStripMenuItem
            // 
            this.deneme1ToolStripMenuItem.Name = "deneme1ToolStripMenuItem";
            this.deneme1ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deneme1ToolStripMenuItem.Text = "Deneme-1";
            // 
            // deneme2ToolStripMenuItem
            // 
            this.deneme2ToolStripMenuItem.Name = "deneme2ToolStripMenuItem";
            this.deneme2ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deneme2ToolStripMenuItem.Text = "Deneme-2";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.BackgroundImage = global::Orman_Takip_Programı.Properties.Resources.button;
            this.çıkışToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.çıkışToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.çıkışToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.çıkışToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(55, 25);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // pnlHarita
            // 
            this.pnlHarita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHarita.AutoScroll = true;
            this.pnlHarita.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlHarita.BackgroundImage = global::Orman_Takip_Programı.Properties.Resources.Screenshot_3;
            this.pnlHarita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHarita.Controls.Add(this.label1);
            this.pnlHarita.Location = new System.Drawing.Point(310, 24);
            this.pnlHarita.Name = "pnlHarita";
            this.pnlHarita.Size = new System.Drawing.Size(507, 433);
            this.pnlHarita.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(224, 48);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(883, 431);
            this.Controls.Add(this.ustMenu);
            this.Controls.Add(this.btnMenuGenislik);
            this.Controls.Add(this.pnlHarita);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.pnlMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ustMenu.ResumeLayout(false);
            this.ustMenu.PerformLayout();
            this.pnlHarita.ResumeLayout(false);
            this.pnlHarita.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlHarita;
        private System.Windows.Forms.Button btnMenuGenislik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip ustMenu;
        private System.Windows.Forms.ToolStripMenuItem kontrol;
        private System.Windows.Forms.ToolStripMenuItem kontrol1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrol2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem denemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deneme1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deneme2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

