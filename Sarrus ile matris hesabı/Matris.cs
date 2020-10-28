using System;
using System.Collections.Generic;
using System.Text;

namespace sayısalAnaliz1
{
    public class Matris
    {
        
        public static int[,] MatrisOlustur()
        {

            int[,] X = new int[3, 3];
            int[,] Y = new int[5, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    X[i, j] = new Random().Next(1, 9);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 3)
                    {
                        for (int t = 0; t < 1; t++)
                        {
                            for (int x = 0; x < 3; x++)
                            {
                                Y[i, x] = X[t, x];
                            }
                        }
                    }

                    else if (i == 4)
                    {
                        for (int t = 1; t < 2; t++)
                        {
                            for (int x = 0; x < 3; x++)
                            {
                                Y[i, x] = X[t, x];
                            }
                        }
                    }
                    else
                    {
                        Y[i, j] = X[i, j];
                    }
                }
            }
            
            return Y;
        }

        public static void Yazdir(int[,] Y)
        {
            for (int i = 0; i < Y.GetLength(0); i++)
            {
                for (int j = 0; j < Y.GetLength(1); j++)
                {
                    Console.Write("{0,3}", Y[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Determinat = " + Sarrus(Y));
        }

        public static int Sarrus(int[,] Y)
        {
            int a, b, determinant;
            a = Y[0, 0] * Y[1, 1] * Y[2, 2] + Y[1, 0] * Y[2, 1] * Y[3, 2] + Y[2, 0] * Y[3, 1] * Y[4, 2];
            b= Y[0, 2] * Y[1, 1] * Y[2, 0] + Y[1, 2] * Y[2, 1] * Y[3, 0] + Y[2, 2] * Y[3, 1] * Y[4, 0];
            determinant = a - b;
            return determinant;
        }




    }
}
