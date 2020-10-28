using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3
{
    public class Sepet
    {
        public double SepeteUrunEkle(Buzdolabı b,LedTv l,CepTel ct,Laptop lp)
        { 
            return b.KdvUygula() + l.KdvUygula() + ct.KdvUygula() + lp.KdvUygula(); 
        }



    }
}
