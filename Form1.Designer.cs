namespace multipleform
{
    partial class Formlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            LOGIN = new Label();
            pictureBox1 = new PictureBox();
            txtusername = new TextBox();
            txtpw = new TextBox();
            txtpw2 = new TextBox();
            btnlogin = new Button();
            btnclose = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LOGIN
            // 
            LOGIN.AutoSize = true;
            LOGIN.BackColor = Color.Transparent;
            LOGIN.Font = new Font("Century Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LOGIN.ForeColor = SystemColors.ButtonHighlight;
            LOGIN.Location = new Point(152, 66);
            LOGIN.Name = "LOGIN";
            LOGIN.Size = new Size(261, 57);
            LOGIN.TabIndex = 0;
            LOGIN.Text = "Welcome!";
            LOGIN.Click += LOGIN_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(454, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.FixedSingle;
            txtusername.Cursor = Cursors.IBeam;
            txtusername.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.ForeColor = Color.Black;
            txtusername.Location = new Point(372, 176);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(245, 28);
            txtusername.TabIndex = 5;
            // 
            // txtpw
            // 
            txtpw.BorderStyle = BorderStyle.FixedSingle;
            txtpw.Cursor = Cursors.IBeam;
            txtpw.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpw.ForeColor = Color.Black;
            txtpw.Location = new Point(372, 238);
            txtpw.Name = "txtpw";
            txtpw.PasswordChar = '*';
            txtpw.Size = new Size(245, 27);
            txtpw.TabIndex = 6;
            // 
            // txtpw2
            // 
            txtpw2.BorderStyle = BorderStyle.FixedSingle;
            txtpw2.Cursor = Cursors.IBeam;
            txtpw2.ForeColor = Color.Black;
            txtpw2.Location = new Point(370, 306);
            txtpw2.Name = "txtpw2";
            txtpw2.PasswordChar = '*';
            txtpw2.Size = new Size(247, 27);
            txtpw2.TabIndex = 7;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Transparent;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatStyle = FlatStyle.Popup;
            btnlogin.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = SystemColors.ButtonHighlight;
            btnlogin.Location = new Point(334, 401);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(111, 49);
            btnlogin.TabIndex = 8;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.Transparent;
            btnclose.Cursor = Cursors.Hand;
            btnclose.FlatStyle = FlatStyle.Popup;
            btnclose.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose.ForeColor = SystemColors.ButtonHighlight;
            btnclose.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose.Location = new Point(726, 457);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(58, 30);
            btnclose.TabIndex = 9;
            btnclose.Text = "X";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(btnclose);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(LOGIN);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtpw2);
            panel1.Controls.Add(txtpw);
            panel1.Location = new Point(-10, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 495);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(150, 309);
            label3.Name = "label3";
            label3.Size = new Size(165, 18);
            label3.TabIndex = 12;
            label3.Text = "CONFIRM PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(228, 241);
            label2.Name = "label2";
            label2.Size = new Size(90, 18);
            label2.TabIndex = 11;
            label2.Text = "PASSWORD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(419, 53);
            label4.Name = "label4";
            label4.Size = new Size(26, 81);
            label4.TabIndex = 10;
            label4.Text = "|\r\n|\r\n|";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(228, 180);
            label1.Name = "label1";
            label1.Size = new Size(87, 18);
            label1.TabIndex = 8;
            label1.Text = "USERNAME";
            // 
            // Formlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 494);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LOGIN;
        private PictureBox pictureBox1;
        private TextBox txtusername;
        private TextBox txtpw;
        private TextBox txtpw2;
        private Button btnlogin;
        private Button btnclose;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}
