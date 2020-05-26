using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE1
{
    public partial class secim_Ekranı : Form
    {
        public secim_Ekranı()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            resim1_form frm = new resim1_form();
            frm.Show();
            this.Hide();

        }

        private void buttonkapat_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            resim2_form frm2 = new resim2_form();
            frm2.Show();
            this.Hide();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            resim6_form frm6 = new resim6_form();
            frm6.Show();
            this.Hide();

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Resim5_form frm5 = new Resim5_form();
            frm5.Show();
            this.Hide();
        }
    }
}
