using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev3
{
    public partial class Form1 : Form
    {
        
        Buzdolabı b1 = new Buzdolabı(682, "A+");
        CepTel ct1 = new CepTel(128, 2, 1821);
        Laptop l1 = new Laptop(40, 16, 41, 15.6, "1920x1080");
        LedTv lt1 = new LedTv(49, "4K");
        Sepet s1 = new Sepet();
        

        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {

            lbAdet.Items.Clear();//Listbox'ı temizler.
            lbKdv.Items.Clear();//Listbox'ı temizler.
            lbUrun.Items.Clear();//Listbox'ı temizler.

            lblS1.Text = lt1.StokAdedi.ToString();
            lblS2.Text = b1.StokAdedi.ToString();
            lblS3.Text = l1.StokAdedi.ToString();
            lblS4.Text = ct1.StokAdedi.ToString();

            lt1.SecilenAdet = Convert.ToInt32(numericUpDown1.Value);
            b1.SecilenAdet = Convert.ToInt32(numericUpDown2.Value);
            l1.SecilenAdet = Convert.ToInt32(numericUpDown3.Value);
            ct1.SecilenAdet = Convert.ToInt32(numericUpDown4.Value);


            if (lt1.SecilenAdet != 0)//NumericUpDown 0'dan farklı ise if bloğunun içerisine girer.
            {
                
                lbAdet.Items.Add(lt1.SecilenAdet);
                lbUrun.Items.Add("Led Tv");
                lbKdv.Items.Add(lt1.KdvUygula());

                for (int i = 0; i < 100; i++)
                {
                    
                }

            }

            if (b1.SecilenAdet != 0)//NumericUpDown 0'dan farklı ise if bloğunun içerisine girer.
            {
                
                lbAdet.Items.Add(b1.SecilenAdet);
                lbUrun.Items.Add("Buzdolabı");
                lbKdv.Items.Add(b1.KdvUygula());
                
            }

            if (l1.SecilenAdet != 0)//NumericUpDown 0'dan farklı ise if bloğunun içerisine girer.
            {
                
                lbAdet.Items.Add(l1.SecilenAdet);
                lbUrun.Items.Add("Laptop");
                lbKdv.Items.Add(Convert.ToDecimal(l1.KdvUygula()));

            }

            if (ct1.SecilenAdet != 0)//NumericUpDown 0'dan farklı ise if bloğunun içerisine girer.
            {
                
                lbAdet.Items.Add(ct1.SecilenAdet);
                lbUrun.Items.Add("Cep Telefonu");
                lbKdv.Items.Add(ct1.KdvUygula());
            }


            lblS1.Text = (lt1.StokAdedi - lt1.SecilenAdet).ToString();//Seçilen ürün miktarı stoktan düşer.
            lblS2.Text = (b1.StokAdedi - b1.SecilenAdet).ToString();//Seçilen ürün miktarı stoktan düşer.
            lblS3.Text = (l1.StokAdedi - l1.SecilenAdet).ToString();//Seçilen ürün miktarı stoktan düşer.
            lblS4.Text = (ct1.StokAdedi - ct1.SecilenAdet).ToString();//Seçilen ürün miktarı stoktan düşer.

            lblF.Text =s1.SepeteUrunEkle(b1, lt1, ct1, l1).ToString();//Toplam fiyat hesaplanır.
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblS1.Text = (lt1.StokAdedi).ToString();//Sepet temizlenince stoktan düşen ürünler tekrar stoğa eklenir.
            lblS2.Text = (b1.StokAdedi).ToString();//Sepet temizlenince stoktan düşen ürünler tekrar stoğa eklenir.
            lblS3.Text = (l1.StokAdedi).ToString();//Sepet temizlenince stoktan düşen ürünler tekrar stoğa eklenir.
            lblS4.Text = (ct1.StokAdedi).ToString();//Sepet temizlenince stoktan düşen ürünler tekrar stoğa eklenir.

            lbAdet.Items.Clear();
            lbKdv.Items.Clear();
            lbUrun.Items.Clear();
        }
    }
}
