using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3
{
    public class CepTel:Urun
    {
        public int DahiliHafiza;
        public int RamKapasitesi;
        public int PilGucu;

        public CepTel(int DahiliHafiza, int RamKapasitesi, int PilGucu)
        {
            
            this.Ad = "Cep Telefonu";
            this.HamFiyat = 2500;
            this.Marka = "İphone";
            this.Model = "8S";
            this.Ozellik = "Plus";
            this.DahiliHafiza = DahiliHafiza;
            this.RamKapasitesi = RamKapasitesi;
            this.PilGucu = PilGucu;

            Random rnd = new Random(Environment.TickCount * 21);//Sistemin başlatılmasından bu yana geçen milisaniye sayısını alır random atama yapar.
            StokAdedi = rnd.Next(1, 100);
        }

        public double KdvUygula()
        {
            return this.HamFiyat * 1.20 * this.SecilenAdet;

        }
    }
}
