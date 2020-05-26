using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE1
{
    public partial class resim1_form : Form
    {



        public resim1_form()
        {
            InitializeComponent();
            txt1.Text = "0";
            txt2.Text = "0";
            txt3.Text = "0";
        }
        
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
          /*  Point point = pictureBox1.PointToClient(Cursor.Position);

            MessageBox.Show(point.ToString()); //koordnatları gösteriyor....*/
            Point point = pictureBox1.PointToClient(Cursor.Position);
            /* listBox1.Text = point.ToString();*/

            listBox1.Items.Add(point.ToString());
           
        }

        
        private void btn_clear_Click(object sender, EventArgs e)
        {

            int sayi = Convert.ToInt32(textBox1.Text);
            switch (sayi)
            {
                case 1:
            btn1.BackColor = Color.White;
            break;
                 case 2:
            btn2.BackColor = Color.White;
             break;
                case 3:
             btn3.BackColor = Color.White;
             break;
                default:
             MessageBox.Show("GEÇERLİ BİR SAYI GİRİNİZ:");
              break;

                   


            
            }
               
           
            
        }

        private void btn_ciz_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 30);
            g.DrawRectangle(Pens.Black, 100, 150, 150, 100);

           
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            btn1.BackColor = Color.Green;
            Point point = pictureBox1.PointToClient(Cursor.Position);
            listBox1.Items.Add("Button1:"+point.ToString());
            txt1.Text = "1";
            
           /* MessageBox.Show(point.ToString()); //koordnatları gösteriyor....*/

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.BackColor = Color.Green;
            Point point = pictureBox1.PointToClient(Cursor.Position);
            listBox1.Items.Add("Button2:" + point.ToString());
            txt2.Text = "1";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.BackColor = Color.Green;
            Point point = pictureBox1.PointToClient(Cursor.Position);
            listBox1.Items.Add("Button2:" + point.ToString());
            txt3.Text = "1";
        }

        private void btn_kaydet_Click(object sender, EventArgs e)

        {
            
            StreamWriter dosya = File.AppendText("C: \\Users\\pakize\\Desktop\\proje.gsr");
            dosya.WriteLine(listBox1.Text);
            MessageBox.Show("Koordinatlar Başarıyla Kaydedildi");
            listBox1.Items.Clear();
            dosya.Close();


            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            secim_Ekranı sc = new secim_Ekranı();
            sc.Show();
            this.Hide();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            // Listbox'ı temizle
            listBox2.Items.Clear();

            // Dosyamızı okuyacak.
            StreamReader oku;

            // Belirtmiş olduğum yoldaki dosyayı açacak. 
            /* NOT: @ bu işareti koymamın nedeni \\ 2 defa bundan yapmamak içindir. */
            oku = File.OpenText("C: \\Users\\pakize\\Desktop\\proje.gsr");

            string yazi;

            // Satır boş olana kadar okumaya devam eder.
            while ((yazi = oku.ReadLine()) != null)
            {
                // Listbox'ı .txt içeriği ile doldur.
                listBox2.Items.Add(yazi.ToString());
            }

            // Okumayı kapat.
            oku.Close();
        }

        private void btnDene_Click(object sender, EventArgs e)
        {
            listbox_dene.Items.Clear();

            int sayi1 = 0;
            int sayi2 = 1;
            int sayi3 = 1;

            int sayi11 = Convert.ToInt32(txt1.Text);
            int sayi22 = Convert.ToInt32(txt2.Text);
            int sayi33 = Convert.ToInt32(txt3.Text);

            if (sayi1 == sayi11)
            {
                listbox_dene.Items.Add ( "1");
            }
            else
            {
                listbox_dene.Items.Add("0");
            }

            if (sayi2 == sayi22)
            {
                listbox_dene.Items.Add("1");
            }
            else
            {
                listbox_dene.Items.Add("0");
            }

            if (sayi3 == sayi33)
            {
                listbox_dene.Items.Add("1");
            }
            else
            {
                listbox_dene.Items.Add("0");
            }
            MessageBox.Show("Kontrol edildi.");

        }
        

    }

       

       
}

