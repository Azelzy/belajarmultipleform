using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multipleform
{
    public partial class Formwiki : Form
    {
        public Formwiki()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda ingin Logout?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Formlogin form1 = new Formlogin();
                form1.Show();
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formhome form3 = new Formhome();
            form3.Show();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCalculator form4 = new FormCalculator();
            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBiodatadiri form5 = new FormBiodatadiri();
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDatapenjualan form6 = new FormDatapenjualan();
            form6.Show();
        }

        private void btnwiki_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formwiki form7 = new Formwiki();
            form7.Show();
        }
    }
}
