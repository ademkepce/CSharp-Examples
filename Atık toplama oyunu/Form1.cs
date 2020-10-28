/***********************************
 
 
            NDP PROJESİ 

ADEM KEPÇE      B191210058      1B


***********************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B191210058_1B_NDP_PROJE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            ButonlariKapat();
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            YeniOyun();
            YeniOyunButonu(false);
            ButonlariAc();
            ResimEkle();
            labelSure.Text = "60";
            _sure = 60;
            timer1.Start();
        }

        public void ButonlariAc()
        {
            button7.Enabled = true;
            button8.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
        }

        public void ButonlariKapat()
        {
            button7.Enabled = false;
            button8.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        public void YeniOyunButonu(bool kontrol)
        {
            buttonYeni.Enabled = kontrol;
        }

        public void YeniOyun()
        {
            _puan = 0;
            labelPuan.Text = Convert.ToString(_puan);
            kutuMetal.Sil();
            kutuCam.Sil();
            kutuKagit.Sil();
            kutuOrganik.Sil();
            ProgressBarDoldur(progressBar4, kutuMetal.DolulukOrani);
            ListeSil(listBox4);
            ProgressBarDoldur(progressBar3, kutuCam.DolulukOrani);
            ListeSil(listBox3);
            ProgressBarDoldur(progressBar2, kutuKagit.DolulukOrani);
            ListeSil(listBox2);
            ProgressBarDoldur(progressBar1, kutuOrganik.DolulukOrani);
            ListeSil(listBox1);
        }

        public void ListeYaz(ListBox listBox, string atik)
        {
            listBox.Items.Add(atik);
        }

        public void ListeSil(ListBox listBox)
        {
            listBox.Items.Clear();
        }

        public void ProgressBarDoldur(ProgressBar progressBar, int dolulukOrani)
        {
            progressBar.Value = dolulukOrani;
        }

        public void ResimEkle()
        {
            // rastgele değişken
            Random random = new Random();
            int r = random.Next(0, 8);
            pictureBox1.ImageLocation = resims[r] + ".jpg";
        }

        private int _puan = 0;
        public void PuanEkle(int puan)
        {
            _puan = _puan + puan;
            labelPuan.Text = Convert.ToString(_puan);
        }

        private int _sure = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_sure > 0)
            {
                _sure -= 1;
                labelSure.Text = Convert.ToString(_sure);
            }
            else
            {
                YeniOyunButonu(true);
                timer1.Stop();
                ButonlariKapat();
            }
        }
        public void SureEkle()
        {
            _sure = _sure + 3;
        }

        KolaKutusu kolaKutusu = new KolaKutusu(350);
        SalcaKutusu salcaKutusu = new SalcaKutusu(550);
        Sise sise = new Sise(600);
        Bardak bardak = new Bardak(250);
        Gazete gazete = new Gazete(250);
        Dergi dergi = new Dergi(200);
        Domates domates = new Domates(150);
        Salatalik salatalik = new Salatalik(120);
        // atiklar
        KutuMetal kutuMetal = new KutuMetal(0);
        KutuCam kutuCam = new KutuCam(0);
        KutuKagit kutuKagit = new KutuKagit(0);
        KutuOrganik kutuOrganik = new KutuOrganik(0);
        // atik kutulari

        string[] resims = new string[8]
        {
            "kolakutusu","salcakutusu","sise","bardak","gazete","dergi","domates","salatalik"
        };
        // resimler listesi

        private void button7_Click(object sender, EventArgs e)      // metal atık butonu 
        {
            if (pictureBox1.ImageLocation == resims[0] + ".jpg" && kolaKutusu.Hacim < kutuMetal.Kapasite - kutuMetal.DoluHacim)
            {
                kutuMetal.Ekle(kolaKutusu);
                PuanEkle(kolaKutusu.Hacim);
                ResimEkle();
                ProgressBarDoldur(progressBar4, kutuMetal.DolulukOrani);
                ListeYaz(listBox4, "Kola Kutusu (350)");
            }
            else if (pictureBox1.ImageLocation == resims[1] + ".jpg" && salcaKutusu.Hacim < kutuMetal.Kapasite - kutuMetal.DoluHacim)
            {
                kutuMetal.Ekle(salcaKutusu);
                PuanEkle(salcaKutusu.Hacim);
                ResimEkle();
                ProgressBarDoldur(progressBar4, kutuMetal.DolulukOrani);
                ListeYaz(listBox4, "Salça Kutusu (550)");
            }
        }

        private void button8_Click(object sender, EventArgs e)      // metal atık bosaltma butonu 
        {
            if (kutuMetal.Bosalt())
            {
                ProgressBarDoldur(progressBar4, kutuMetal.DolulukOrani);
                PuanEkle(kutuMetal.BosaltmaPuani);
                SureEkle();
                ListeSil(listBox4);
            }
        }

        private void button5_Click(object sender, EventArgs e)      // cam atık butonu 
        {
            if (pictureBox1.ImageLocation == resims[2] + ".jpg" && sise.Hacim < kutuCam.Kapasite - kutuCam.DoluHacim)
            {
                kutuCam.Ekle(sise);
                PuanEkle(sise.Hacim);
                ResimEkle();
                ProgressBarDoldur(progressBar3, kutuCam.DolulukOrani);
                ListeYaz(listBox3, "Cam Şişe (600)");
            }
            else if (pictureBox1.ImageLocation == resims[3] + ".jpg" && bardak.Hacim < kutuCam.Kapasite - kutuCam.DoluHacim)
            {
                kutuCam.Ekle(bardak);
                PuanEkle(bardak.Hacim);
                ResimEkle();
                ProgressBarDoldur(progressBar3, kutuCam.DolulukOrani);
                ListeYaz(listBox3, "Bardak (250)");
            }
        }

        private void button6_Click(object sender, EventArgs e)      // cam atık bosaltma butonu 
        {
            if (kutuCam.Bosalt())
            {
                ProgressBarDoldur(progressBar3, kutuCam.DolulukOrani);
                PuanEkle(kutuCam.BosaltmaPuani);
                SureEkle();
                ListeSil(listBox3);
            }
        }

        private void button3_Click(object sender, EventArgs e)      // kagit atık butonu 
        {
            if (pictureBox1.ImageLocation == resims[4] + ".jpg" && gazete.Hacim < kutuKagit.Kapasite - kutuKagit.DoluHacim)
            {
                kutuKagit.Ekle(gazete);
                PuanEkle(gazete.Hacim);
                ResimEkle();
                ProgressBarDoldur(progressBar2, kutuKagit.DolulukOrani);
                ListeYaz(listBox2, "Gazete (250)");
            }
            else if (pictureBox1.ImageLocation == resims[5] + ".jpg" && dergi.Hacim < kutuKagit.Kapasite - kutuKagit.DoluHacim)
            {
                kutuKagit.Ekle(dergi);
                PuanEkle(dergi.Hacim);
                ResimEkle();
                ProgressBarDoldur(progressBar2, kutuKagit.DolulukOrani);
                ListeYaz(listBox2, "Dergi (200)");
            }
        }

        private void button4_Click(object sender, EventArgs e)      // kagit atık bosaltma butonu 
        {
            if (kutuKagit.Bosalt())
            {
                kutuKagit.Bosalt();
                ProgressBarDoldur(progressBar2, kutuKagit.DolulukOrani);
                PuanEkle(kutuKagit.BosaltmaPuani);
                SureEkle();
                ListeSil(listBox2);
            }
        }

        private void button1_Click(object sender, EventArgs e)      // organik atık butonu 
        {
            if (pictureBox1.ImageLocation == resims[6] + ".jpg" && domates.Hacim < kutuOrganik.Kapasite - kutuOrganik.DoluHacim)
            {
                kutuOrganik.Ekle(domates);
                PuanEkle(domates.Hacim);
                ResimEkle();
                ProgressBarDoldur(progressBar1, kutuOrganik.DolulukOrani);
                ListeYaz(listBox1, "Domates (150)");
            }
            else if (pictureBox1.ImageLocation == resims[7] + ".jpg" && salatalik.Hacim < kutuOrganik.Kapasite - kutuOrganik.DoluHacim)
            {
                kutuOrganik.Ekle(salatalik);
                PuanEkle(salatalik.Hacim);
                ResimEkle();
                ProgressBarDoldur(progressBar1, kutuOrganik.DolulukOrani);
                ListeYaz(listBox1, "Salatalık (120)");
            }
        }

        private void button2_Click(object sender, EventArgs e)      // organik atık bosaltma butonu 
        {
            if (kutuOrganik.Bosalt())
            {
                ProgressBarDoldur(progressBar1, kutuOrganik.DolulukOrani);
                PuanEkle(kutuOrganik.BosaltmaPuani);
                SureEkle();
                ListeSil(listBox1);
            }
        }

        private void buttonCik_Click(object sender, EventArgs e)    // cikis butonu
        {
            this.Close();
        }
    }
}