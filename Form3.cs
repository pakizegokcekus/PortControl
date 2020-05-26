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
    public partial class resim2_form : Form
    {
        public resim2_form()
        {
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            secim_Ekranı sc = new secim_Ekranı();
            sc.Show();
            this.Hide();
        }
    }
}
