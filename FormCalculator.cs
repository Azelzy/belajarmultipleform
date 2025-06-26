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
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formhome form3 = new Formhome();
            form3.Show();
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

        private void btnbiotata_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBiodatadiri form5 = new FormBiodatadiri();
            form5.Show();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCalculator form4 = new FormCalculator();
            form4.Show();
        }

        private void btndatapenjualan_Click(object sender, EventArgs e)
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

        private void btntambah_Click(object sender, EventArgs e)
        {
            
            int number1 = int.Parse(txtangkaA.Text);
            int number2 = int.Parse(txtangkaB.Text);
            int tambah = number1 + number2;
            txthasil.Text = tambah.ToString();
            
        }

        private void btnkurang_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txtangkaA.Text);
            int number2 = int.Parse(txtangkaB.Text);
            int tambah = number1 - number2;
            txthasil.Text = tambah.ToString();
        }

        private void btnkali_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txtangkaA.Text);
            int number2 = int.Parse(txtangkaB.Text);
            int tambah = number1 * number2;
            txthasil.Text = tambah.ToString();

        }

        private void btnbagi_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txtangkaA.Text);
            int number2 = int.Parse(txtangkaB.Text);
            int tambah = number1 / number2;
            txthasil.Text = tambah.ToString();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            txtangkaA.Text = "";
            txtangkaB.Text = "";
            txthasil.Text = "";
        }
    }
}
