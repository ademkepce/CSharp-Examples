using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3
{
    public class Laptop:Urun
    {
        public double EkranBoyutu;
        public string EkranCozunurlugu;
        public int DahiliHafiza;
        public int RamKapasitesi;
        public int PilGucu;

        public Laptop(int DahiliHafiza, int RamKapasitesi, int PilGucu, double EkranBoyutu, string EkranCozunurlugu)
        {
            
            this.Ad = "Laptop";
            this.HamFiyat = 6000;
            this.Marka = "Monster";
            this.Model = "Abra";
            this.Ozellik = "Game Computer";
            this.DahiliHafiza = DahiliHafiza;
            this.RamKapasitesi = RamKapasitesi;
            this.PilGucu = PilGucu;
            this.EkranCozunurlugu = EkranCozunurlugu;

            Random rnd = new Random(Environment.TickCount * 17);//Sistemin başlatılmasından bu yana geçen milisaniye sayısını alır random atama yapar.
            StokAdedi = rnd.Next(1, 100);
        }

        public double KdvUygula()
        {
            return this.HamFiyat * 1.15 * this.SecilenAdet;

        }
    }
}
