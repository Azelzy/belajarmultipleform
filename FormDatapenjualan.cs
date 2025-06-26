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
    public partial class FormDatapenjualan : Form
    {
        public FormDatapenjualan()
        {
            InitializeComponent();
            NUDbanyak.Value = 1;
            cmbhargasatuan.SelectedIndex = 0;
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            string namabarang = txttambahbarang.Text;
            cmbitembarang.Items.Add(namabarang);
        }

        private void btnbeli_Click(object sender, EventArgs e)
        {
            if (cmbitembarang.Text == "powerpoint")
            {
                mpowerpoint.Visible = true;
                msword.Visible = false;
                mexcel.Visible = false;
            }
            else if (cmbitembarang.Text == "msword")
            {
                msword.Visible = true;
                mpowerpoint.Visible = false;
                mexcel.Visible = false;
            }
            else if (cmbitembarang.Text == "msexcel")
            {
                mexcel.Visible = true;
                mpowerpoint.Visible = false;
                msword.Visible = false;
            }

            listBoxbeli.Items.Clear();
            listBoxbeli.Items.Add("NOTA PEMBELIAN");
            listBoxbeli.Items.Add("User telah membeli : " + cmbitembarang.Text);
            listBoxbeli.Items.Add("User telah membeli sebanyak : " + NUDbanyak.Text);
            listBoxbeli.Items.Add("Harga satuan : " + cmbhargasatuan.Text);
        }

        private void btnbayar_Click(object sender, EventArgs e)
        {
            int jumlah = (int)NUDbanyak.Value;

            if (cmbhargasatuan.SelectedIndex != -1 && decimal.TryParse(cmbhargasatuan.SelectedItem.ToString(), out decimal harga))
            {
                decimal total = harga * jumlah;
                txttotalharga.Text = total.ToString();
                listBoxbeli.Items.Add("total : " + txttotalharga.Text);
            }
            else
            {
                MessageBox.Show("User belum bayar");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            
            txttambahbarang.Text = "";
            cmbitembarang.Items.Clear();
            NUDbanyak.Value = 1;
            listBoxbeli.Items.Clear();
            txttotalharga.Text = "";
            cmbhargasatuan.SelectedIndex = 0;
            cmbitembarang.Text = "";
            msword.Visible = false;
            mpowerpoint.Visible = false;
            mexcel.Visible = false;
        }
    }
}
