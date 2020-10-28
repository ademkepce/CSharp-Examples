/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**			   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:B191210058
**				ÖĞRENCİ ADI............:ADEM
**				ÖĞRENCİ NUMARASI.......:KEPÇE
**              DERSİN ALINDIĞI GRUP...:B
****************************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace odevIki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Height = 700;
            this.Width = 1000;

            var lbl3 = new Label()
            {
                Text = "X",
                Top = 37,
                Left = 539,
            };

            var lbl4 = new Label()
            {
                Text = "Y",
                Top = 37,
                Left = 721,
            };

            var lbx1 = new ListBox()
            {

                Top = 57,
                Left = 496,
                Height = 292,
                Width=120,
                BackColor=Color.White,
                HorizontalScrollbar=true,

            };

            var lbx2 = new ListBox()
            {

                Top = 57,
                Left = 670,
                Height = 292,
                Width = 120,
                BackColor = Color.White,
                HorizontalScrollbar = true,
            };

            var lbl5 = new Label()
            {
                Text = "TOPLAMLAR =",
                Top = 382,
                Left = 372,
            };

            var txb3 = new TextBox()
            {
                Top = 378,
                Left = 496,
                BackColor = Color.White,
            };

            var txb4 = new TextBox()
            {
                Top = 377,
                Left = 670,
                BackColor = Color.White,
            };

            this.Controls.Add(lbl3);
            this.Controls.Add(lbl4);
            this.Controls.Add(lbx1);
            this.Controls.Add(lbx2);
            this.Controls.Add(lbl5);
            this.Controls.Add(txb3);
            this.Controls.Add(txb4);

            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int toplam1 = 0, toplam2 = 0;

            for (int i = 1; i <sayi1; i++)//X listbox'na birinci sayının çarpanlarını yazan döngü.
            {
                if (sayi1%i==0)
                {
                    lbx1.Items.Add(i);
                    toplam1 = toplam1 + i;
                    txb3.Text = toplam1.ToString();
                }
                
            }
            
            for (int a = 1; a < sayi2; a++)//Y listbox'na ikinci sayının çarpanlarını yazan döngü.
            {
                if (sayi2 % a == 0)
                {
                    lbx2.Items.Add(a);
                    toplam2 = toplam2 + a;
                    txb4.Text = toplam2.ToString();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();//Sonlandırma.
        }

    }
}
