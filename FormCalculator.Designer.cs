namespace multipleform
{
    partial class FormCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculator));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btndatapenjualan = new Button();
            btnbiotata = new Button();
            btnlogout = new Button();
            btnwiki = new Button();
            btncalc = new Button();
            btnhome = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            Kalkulator = new GroupBox();
            btnhapus = new Button();
            btnbagi = new Button();
            btnkali = new Button();
            btnkurang = new Button();
            btntambah = new Button();
            txthasil = new TextBox();
            txtangkaB = new TextBox();
            txtangkaA = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            Kalkulator.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btndatapenjualan);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnbiotata);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btnwiki);
            panel1.Controls.Add(btncalc);
            panel1.Controls.Add(btnhome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 79);
            panel1.TabIndex = 12;
            // 
            // btndatapenjualan
            // 
            btndatapenjualan.BackColor = Color.Transparent;
            btndatapenjualan.FlatStyle = FlatStyle.Popup;
            btndatapenjualan.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndatapenjualan.ForeColor = SystemColors.ButtonHighlight;
            btndatapenjualan.Location = new Point(660, 17);
            btndatapenjualan.Name = "btndatapenjualan";
            btndatapenjualan.Size = new Size(170, 38);
            btndatapenjualan.TabIndex = 10;
            btndatapenjualan.Text = "DATA PENJUALAN";
            btndatapenjualan.UseVisualStyleBackColor = false;
            btndatapenjualan.Click += btndatapenjualan_Click;
            // 
            // btnbiotata
            // 
            btnbiotata.BackColor = Color.Transparent;
            btnbiotata.FlatStyle = FlatStyle.Popup;
            btnbiotata.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbiotata.ForeColor = SystemColors.ButtonHighlight;
            btnbiotata.Location = new Point(548, 17);
            btnbiotata.Name = "btnbiotata";
            btnbiotata.Size = new Size(106, 38);
            btnbiotata.TabIndex = 9;
            btnbiotata.Text = "BIODATA ";
            btnbiotata.UseVisualStyleBackColor = false;
            btnbiotata.Click += btnbiotata_Click;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.Firebrick;
            btnlogout.FlatStyle = FlatStyle.Popup;
            btnlogout.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.White;
            btnlogout.Location = new Point(967, 17);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(83, 38);
            btnlogout.TabIndex = 8;
            btnlogout.Text = "LOGOUT";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnwiki
            // 
            btnwiki.BackColor = Color.Transparent;
            btnwiki.FlatStyle = FlatStyle.Popup;
            btnwiki.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnwiki.ForeColor = SystemColors.ButtonHighlight;
            btnwiki.Location = new Point(835, 17);
            btnwiki.Name = "btnwiki";
            btnwiki.Size = new Size(127, 38);
            btnwiki.TabIndex = 7;
            btnwiki.Text = "SIMPLE WIKI";
            btnwiki.UseVisualStyleBackColor = false;
            btnwiki.Click += btnwiki_Click;
            // 
            // btncalc
            // 
            btncalc.BackColor = SystemColors.Desktop;
            btncalc.FlatStyle = FlatStyle.Popup;
            btncalc.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncalc.ForeColor = Color.White;
            btncalc.Location = new Point(409, 17);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(133, 38);
            btncalc.TabIndex = 6;
            btncalc.Text = "CALCULATOR";
            btncalc.UseVisualStyleBackColor = false;
            btncalc.Click += btncalc_Click;
            // 
            // btnhome
            // 
            btnhome.BackColor = Color.Transparent;
            btnhome.FlatStyle = FlatStyle.Popup;
            btnhome.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnhome.ForeColor = SystemColors.ButtonHighlight;
            btnhome.Location = new Point(323, 17);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(80, 38);
            btnhome.TabIndex = 5;
            btnhome.Text = "HOME";
            btnhome.UseVisualStyleBackColor = false;
            btnhome.Click += btnhome_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 517);
            panel2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(98, 242);
            label3.Name = "label3";
            label3.Size = new Size(272, 112);
            label3.TabIndex = 3;
            label3.Text = "Kalkulator \r\nSederhana";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(98, 327);
            label2.Name = "label2";
            label2.Size = new Size(297, 56);
            label2.TabIndex = 2;
            label2.Text = ". . . . . . . . . . .";
            // 
            // Kalkulator
            // 
            Kalkulator.BackColor = Color.Transparent;
            Kalkulator.Controls.Add(btnhapus);
            Kalkulator.Controls.Add(btnbagi);
            Kalkulator.Controls.Add(btnkali);
            Kalkulator.Controls.Add(btnkurang);
            Kalkulator.Controls.Add(btntambah);
            Kalkulator.Controls.Add(txthasil);
            Kalkulator.Controls.Add(txtangkaB);
            Kalkulator.Controls.Add(txtangkaA);
            Kalkulator.Controls.Add(label5);
            Kalkulator.Controls.Add(label4);
            Kalkulator.Controls.Add(label1);
            Kalkulator.ForeColor = SystemColors.ButtonHighlight;
            Kalkulator.Location = new Point(464, 152);
            Kalkulator.Name = "Kalkulator";
            Kalkulator.Size = new Size(515, 281);
            Kalkulator.TabIndex = 15;
            Kalkulator.TabStop = false;
            Kalkulator.Text = "KALKULATOR";
            // 
            // btnhapus
            // 
            btnhapus.FlatStyle = FlatStyle.Popup;
            btnhapus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnhapus.Location = new Point(157, 230);
            btnhapus.Name = "btnhapus";
            btnhapus.Size = new Size(72, 38);
            btnhapus.TabIndex = 10;
            btnhapus.Text = "Clear";
            btnhapus.UseVisualStyleBackColor = true;
            btnhapus.Click += btnhapus_Click;
            // 
            // btnbagi
            // 
            btnbagi.FlatStyle = FlatStyle.Popup;
            btnbagi.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbagi.Location = new Point(360, 140);
            btnbagi.Name = "btnbagi";
            btnbagi.Size = new Size(93, 46);
            btnbagi.TabIndex = 9;
            btnbagi.Text = ":";
            btnbagi.UseVisualStyleBackColor = true;
            btnbagi.Click += btnbagi_Click;
            // 
            // btnkali
            // 
            btnkali.FlatStyle = FlatStyle.Popup;
            btnkali.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnkali.Location = new Point(251, 140);
            btnkali.Name = "btnkali";
            btnkali.Size = new Size(93, 46);
            btnkali.TabIndex = 8;
            btnkali.Text = "x";
            btnkali.UseVisualStyleBackColor = true;
            btnkali.Click += btnkali_Click;
            // 
            // btnkurang
            // 
            btnkurang.FlatStyle = FlatStyle.Popup;
            btnkurang.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnkurang.Location = new Point(360, 74);
            btnkurang.Name = "btnkurang";
            btnkurang.Size = new Size(93, 46);
            btnkurang.TabIndex = 7;
            btnkurang.Text = "-";
            btnkurang.UseVisualStyleBackColor = true;
            btnkurang.Click += btnkurang_Click;
            // 
            // btntambah
            // 
            btntambah.FlatStyle = FlatStyle.Popup;
            btntambah.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntambah.Location = new Point(251, 74);
            btntambah.Name = "btntambah";
            btntambah.Size = new Size(93, 46);
            btntambah.TabIndex = 6;
            btntambah.Text = "+";
            btntambah.UseVisualStyleBackColor = true;
            btntambah.Click += btntambah_Click;
            // 
            // txthasil
            // 
            txthasil.BorderStyle = BorderStyle.FixedSingle;
            txthasil.Location = new Point(161, 194);
            txthasil.Name = "txthasil";
            txthasil.Size = new Size(67, 27);
            txthasil.TabIndex = 5;
            // 
            // txtangkaB
            // 
            txtangkaB.BorderStyle = BorderStyle.FixedSingle;
            txtangkaB.Location = new Point(161, 137);
            txtangkaB.Name = "txtangkaB";
            txtangkaB.Size = new Size(67, 27);
            txtangkaB.TabIndex = 4;
            // 
            // txtangkaA
            // 
            txtangkaA.BorderStyle = BorderStyle.FixedSingle;
            txtangkaA.Location = new Point(161, 76);
            txtangkaA.Name = "txtangkaA";
            txtangkaA.Size = new Size(67, 27);
            txtangkaA.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 194);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 2;
            label5.Text = "HASIL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 137);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 1;
            label4.Text = "ANGKA B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 81);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "ANGKA A";
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1073, 596);
            Controls.Add(Kalkulator);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCalculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Kalkulator.ResumeLayout(false);
            Kalkulator.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btndatapenjualan;
        private Button btnbiotata;
        private Button btnlogout;
        private Button btnwiki;
        private Button btncalc;
        private Button btnhome;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private GroupBox Kalkulator;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button btnhapus;
        private Button btnbagi;
        private Button btnkali;
        private Button btnkurang;
        private Button btntambah;
        private TextBox txthasil;
        private TextBox txtangkaB;
        private TextBox txtangkaA;
    }
}