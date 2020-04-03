using System;
using System.Globalization;

namespace uri1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaA = 5.0;
            double notaB = 6.0;
            double notaC = 7.0;

            double pesoA = 2;
            double pesoB = 3;
            double pesoC = 5;
            double media;

            notaA = double.Parse(Console.ReadLine());
            notaB = double.Parse(Console.ReadLine());
            notaC = double.Parse(Console.ReadLine());

            media = (notaA * pesoA +  notaB * pesoB + notaC * pesoC) / (pesoA + pesoB + pesoC);
            Console.WriteLine("MEDIA = " + media.ToString("F1"));
        }
    }
}