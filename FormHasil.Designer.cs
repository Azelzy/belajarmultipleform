namespace multipleform
{
    partial class FormHasil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHasil));
            btnlogout = new Button();
            label1 = new Label();
            btnlanjut = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.Firebrick;
            btnlogout.Cursor = Cursors.Hand;
            btnlogout.FlatStyle = FlatStyle.Popup;
            btnlogout.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.Location = new Point(429, 283);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(168, 50);
            btnlogout.TabIndex = 0;
            btnlogout.Text = "KEMBALI";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(44, 5);
            label1.Name = "label1";
            label1.Size = new Size(553, 57);
            label1.TabIndex = 1;
            label1.Text = "ANDA BERHASIL LOGIN!";
            // 
            // btnlanjut
            // 
            btnlanjut.BackColor = Color.DarkGreen;
            btnlanjut.Cursor = Cursors.Hand;
            btnlanjut.FlatStyle = FlatStyle.Popup;
            btnlanjut.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlanjut.Location = new Point(30, 283);
            btnlanjut.Name = "btnlanjut";
            btnlanjut.Size = new Size(168, 50);
            btnlanjut.TabIndex = 2;
            btnlanjut.Text = "LANJUT";
            btnlanjut.UseVisualStyleBackColor = false;
            btnlanjut.Click += btnlanjut_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(246, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(253, 216);
            label2.Name = "label2";
            label2.Size = new Size(131, 26);
            label2.TabIndex = 4;
            label2.Text = "-- AZELZY --";
            // 
            // FormHasil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(623, 363);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnlanjut);
            Controls.Add(label1);
            Controls.Add(btnlogout);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHasil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHasil";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogout;
        private Label label1;
        private Button btnlanjut;
        private PictureBox pictureBox1;
        private Label label2;
    }
}