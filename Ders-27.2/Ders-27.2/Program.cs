﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_27._2    // Consoldan girilen degerleri duz ve tersten yazdirma

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int satir, sutun;

            Console.Write("Satir sayisini giriniz:");
            satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sutun sayisini giriniz:");
            sutun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[,] matrix = new int[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("Matrixin {0} x {1} Degeri: ", i + 1, j + 1);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Matrix degerlerinin normal yazilimi:");
            for (int k = 0; k < satir; k++)
            {
                for (int n = 0; n < sutun; n++)
                {
                    Console.Write(matrix[k, n] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("Matrix degerlerinin tersten yazilimi:");
            for (int x = 0; x < satir; x++)
            {
                for (int y = 0; y < sutun; y++)
                {
                    Console.Write(matrix[y, x] + " ");
                }
                Console.WriteLine();

            }
            Console.Read();
        }
    }
}
