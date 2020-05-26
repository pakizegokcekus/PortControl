using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;



namespace PROJE1
{
    public partial class Resim5_form : Form
    {
        public Resim5_form()
        {
            InitializeComponent();
        }

      
        private void Resim3_form_Load(object sender, EventArgs e)
        {
            for(int i = 1; i < 11; i++)
            {
                checkedListBox1.Items.Add((i) + ".port");
            }
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            secim_Ekranı sc1 = new secim_Ekranı();
            sc1.Show();
            this.Hide();
        }

        private void button_sec_Click(object sender, EventArgs e)
        {
            int toplam = checkedListBox1.Items.Count;
            for(int i = 0; i < toplam; i++)
            {
                checkedListBox1.SetItemChecked(i, true);

            }
            checkedListBox2.Items.Clear();
            checkedListBox2.Items.Add("Tüm Portları Açtınız!");

        }

        private void button_kaldır_Click(object sender, EventArgs e)
        {
            int toplam = checkedListBox1.Items.Count;
            for(int i = 0; i < toplam; i++)
            {
                checkedListBox1.SetItemChecked(i, false);

            }
                checkedListBox2.Items.Clear();
                checkedListBox2.Items.Add("Tüm Portları Kapattınız!");
            
        }

        private void button_uygula_Click(object sender, EventArgs e)
        {
            listBox_seçim.Items.Clear();

            for(int i = 1; i < 11; i++)
            {
                if (checkedListBox1.GetItemChecked(i-1))
                {
                    listBox_seçim.Items.Add(i + ".port=1");
                }
                else
                    listBox_seçim.Items.Add(i + ".port=0");
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox2.Items.Clear();

            for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (!checkedListBox1.GetItemChecked(i))
                {
                    checkedListBox2.Items.Add(checkedListBox1.Items[i].ToString());
                }
            }
        }

        private void button_kontrol_Click(object sender, EventArgs e)
        {

          

            listBox_hazır.Items.Clear();
            listBox_hazır.Items.Add("1.port=0");
            for(int i = 2; i < 11; i++)
            {
                listBox_hazır.Items.Add(i + ".port=1");
            }


            listBox_sonuc.Items.Clear();

            for(int i = 0; i < 10; i++)
            {
                if (listBox_hazır.Items[i].ToString() != listBox_seçim.Items[i].ToString())
                {
                    listBox_sonuc.Items.Add((i + 1) + ".port=0");
                }
                else
                    listBox_sonuc.Items.Add((i + 1) + ".port=1");
            }

          
        }

      
    }
}
