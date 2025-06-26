namespace multipleform
{
    partial class Formwiki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formwiki));
            panel1 = new Panel();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btnlogout = new Button();
            btnwiki = new Button();
            btncalc = new Button();
            btnhome = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btnwiki);
            panel1.Controls.Add(btncalc);
            panel1.Controls.Add(btnhome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1063, 79);
            panel1.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(660, 17);
            button2.Name = "button2";
            button2.Size = new Size(170, 38);
            button2.TabIndex = 10;
            button2.Text = "DATA PENJUALAN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(548, 17);
            button1.Name = "button1";
            button1.Size = new Size(106, 38);
            button1.TabIndex = 9;
            button1.Text = "BIODATA ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            btnwiki.BackColor = SystemColors.Desktop;
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
            btncalc.BackColor = Color.Transparent;
            btncalc.FlatStyle = FlatStyle.Popup;
            btncalc.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncalc.ForeColor = SystemColors.ButtonHighlight;
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
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(1063, 79);
            panel2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(291, 3);
            label1.Name = "label1";
            label1.Size = new Size(504, 70);
            label1.TabIndex = 0;
            label1.Text = "NOVA PROSPEKT";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 555);
            panel3.Name = "panel3";
            panel3.Size = new Size(1063, 34);
            panel3.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Uighur", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(13, 9);
            label3.Name = "label3";
            label3.Size = new Size(151, 27);
            label3.TabIndex = 0;
            label3.Text = "©AZKA EL FACHRIZY";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(pictureBox2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 158);
            panel4.Name = "panel4";
            panel4.Size = new Size(1063, 397);
            panel4.TabIndex = 18;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(548, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(471, 253);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(300, 287);
            label2.Name = "label2";
            label2.Size = new Size(480, 60);
            label2.TabIndex = 1;
            label2.Text = "Nova Prospekt is a Combine detainment facility featured in Half-Life 2. \r\nIt is played through two chapters set between the Coast \r\nand the City 17 uprising chapters, Nova Prospekt and Entanglement.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(54, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(471, 253);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Formwiki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1063, 589);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formwiki";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formwiki";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button btnlogout;
        private Button btnwiki;
        private Button btncalc;
        private Button btnhome;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}