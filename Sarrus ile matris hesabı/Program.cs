using System;

namespace sayısalAnaliz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Y = Matris.MatrisOlustur();
            Matris.Yazdir(Y);
            Matris.Sarrus(Y);
        }
    }
}
