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
    public partial class FormHasil : Form
    {
        public FormHasil()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formlogin form1 = new Formlogin();
            form1.Show();
        }

        private void btnlanjut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formhome form3 = new Formhome();
            form3.Show();
        }
    }
}
