using System;
using System.Globalization;

namespace uri1013
{
    class Program
    {
        static void Main(string[] args)
        {
        int a, b, c, maiorAB, maior;
        String[] vet = Console.ReadLine().Split(' ');

        a = int.Parse(vet[0]);
        b = int.Parse(vet[1]);
        c = int.Parse(vet[2]);

        maiorAB = (a + b + Math.Abs(a - b)) / 2;
        maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;
        Console.WriteLine(maior + " eh o maior");
        }
    }
}