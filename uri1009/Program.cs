using System;
using System.Globalization;

namespace uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            double salarioFixo = 500.00;
            double valorVendas = 1230.00;
            double total;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine());
            valorVendas = double.Parse(Console.ReadLine());

            total = salarioFixo + (valorVendas * 15)/100;
            Console.WriteLine("TOTAL = R$ " +total.ToString("F2"));
        }
    }
}