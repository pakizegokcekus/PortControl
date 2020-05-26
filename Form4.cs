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
    public partial class resim6_form : Form
    {



       // public object CheckedListBoxpn { get; private set; }

        public resim6_form()
        {
            InitializeComponent();
            
        }



        private void resim6_form_Load(object sender, EventArgs e)
        {
            

           for (int i = 1; i < 69; i++)// index numaralarıyla işlem yapmak için kapatıldı..

            {
                
                checkedListBox1.Items.Add((i) + ".port");

            }

           




        }

        private void btn_sec_Click(object sender, EventArgs e)
        {
            int toplam = checkedListBox1.Items.Count;
            for (int i = 0; i < toplam; i++)
            {
                checkedListBox1.SetItemChecked(i, true);

            }
            checkedListBox2.Items.Clear();
            checkedListBox2.Items.Add("Tüm Portları Açtınız!");
        }

        private void btn_kaldır_Click(object sender, EventArgs e)
        {

            
            int toplam = checkedListBox1.Items.Count;
            for (int i = 0; i < toplam; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            checkedListBox2.Items.Clear();
            checkedListBox2.Items.Add("Tüm Portları Kapattınız!");
        }



        private void btn_uygula_Click(object sender, EventArgs e)
        {
            listbox_secim.Items.Clear();
            for (int i = 1; i < 69; i++)

            {
                if (!checkedListBox1.GetItemChecked(i-1))
                    listbox_secim.Items.Add(i + ".port=0");

                else
                    listbox_secim.Items.Add(i + ".port=1");


            }
           
         



        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox2.Items.Clear();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (!checkedListBox1.GetItemChecked(i))
                {
                    checkedListBox2.Items.Add(checkedListBox1.Items[i].ToString());
                }
            }


        }

        private void btn_kontrolEt_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphicsObj1 = pictureBox1.CreateGraphics();
            Pen myPen1 = new Pen(System.Drawing.Color.Red, 5);
            Rectangle myRectangle1 = new Rectangle(20, 20, 150, 100);
            graphicsObj1.DrawRectangle(myPen1, myRectangle1);

            listBox_hazır.Items.Clear();
            listBox_hazır.Items.Add("1.port=0");
            listBox_hazır.Items.Add("2.port=0");
           
            for (int i = 3; i < 69; i++)
            {
                listBox_hazır.Items.Add((i) + ".port=1");


            }


            listBox_kontrol.Items.Clear();
           
            for (int i = 0; i <68; i++)
            {
                if (listBox_hazır.Items[i].ToString() != listbox_secim.Items[i].ToString())
                {
                    listBox_kontrol.Items.Add((i + 1) + ".port=0");
                }
                else
                    listBox_kontrol.Items.Add((i + 1) + ".port=1");
            }
           
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            secim_Ekranı sc1 = new secim_Ekranı();
            sc1.Show();
            this.Hide();
            
          
        }

      
    }
    


}   

 
    

