using System;
using System.Globalization;

namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFunc = 25;
            int hrs = 100;
            double slrHora = 5.50;
            double salario;
            
            numFunc = int.Parse(Console.ReadLine());
            hrs = int.Parse(Console.ReadLine());
            slrHora = double.Parse(Console.ReadLine());
            salario = slrHora * hrs;

            Console.WriteLine("NUMBER = " + numFunc);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
        }
    }
}