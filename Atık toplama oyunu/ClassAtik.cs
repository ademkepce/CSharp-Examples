/***********************************
 
 
NDP PROJESİ 

ADEM KEPÇE      B191210058      1B


***********************************/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B191210058_1B_NDP_PROJE
{
    public class ClassAtik : IAtik      // ana atik sınıfı
    {
        public ClassAtik(int hacim)
        {
            Hacim = hacim;
        }
        public int Hacim { get; }
        public Image Image { get; }
    }
}