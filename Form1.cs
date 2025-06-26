using System.Diagnostics.Eventing.Reader;

namespace multipleform
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin Ingin Keluar?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = "azelzy";
            
            string password = "123";
            
            

            if (txtusername.Text == user & txtpw.Text == password & txtpw2.Text == txtpw.Text)
            {
                this.Hide();
                FormHasil form2 = new FormHasil();
                form2.Show();

            }
            else
            {
                MessageBox.Show("Username atau password tidak benar harap coba lagi", "INFORMASI", MessageBoxButtons.OK);
                txtusername.Text = string.Empty;
                txtpw.Text = string.Empty;
                txtpw2.Text = string.Empty;
            }  
            
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
