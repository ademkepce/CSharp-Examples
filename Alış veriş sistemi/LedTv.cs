using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3
{
    public class LedTv:Urun
    {
        public int EkranBoyutu;
        public string EkranCozunurlugu;

        public LedTv(int EkranBoyutu, string EkranCozunurlugu)
        {
            
            this.Ad = "Led Tv";
            this.HamFiyat = 4000;
            this.Marka = "LG";
            this.Model = "49SM8200PLA";
            this.Ozellik = "4K";
            this.EkranBoyutu = EkranBoyutu;
            this.EkranCozunurlugu = EkranCozunurlugu;

            Random rnd = new Random(Environment.TickCount * 19);//Sistemin başlatılmasından bu yana geçen milisaniye sayısını alır random atama yapar.
            StokAdedi = rnd.Next(1, 100);
        }

        public double KdvUygula()
        {
            return this.HamFiyat * 1.18 * this.SecilenAdet;

        }
    }
}
