using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3
{
    public class Buzdolabı:Urun
    {

        public int IcHacim;
        public string EnerjiSinifi;
       
        public Buzdolabı(int IcHacim, string EnerjiSinifi)
        {

            this.Ad = "Buzdolabı";
            this.HamFiyat = 3500;
            this.Marka = "Bosch";
            this.Model = "KGN86AI42N";
            this.Ozellik = "No Frost";
            this.IcHacim = IcHacim;
            this.EnerjiSinifi = EnerjiSinifi;

            Random rnd = new Random(Environment.TickCount*16);//Sistemin başlatılmasından bu yana geçen milisaniye sayısını alır random atama yapar.
            StokAdedi = rnd.Next(1, 100);

        }


        public double KdvUygula()
        {
             return this.HamFiyat * 1.05 * this.SecilenAdet;

        }


    }
}
