using System;
using System.Globalization;
namespace uri1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, medio, maior;
            int menor = 0;

            string[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            if (x < y && x < z)
            {
                x = menor;
                if (y < z)
                {
                    medio = y;
                    maior = z;
                }
                else
                {
                    medio = z;
                    maior = y;
                }
            }

            else if (y < x && y < z)
            {
                menor = y;
                if (x < z)
                {
                    medio = x;
                    maior = z;
                }
                else
                {
                    medio = z;
                    maior = x;
                }
            }

            else
            {
                menor = z;
                if (x < y)
                {
                    medio = x;
                    maior = y;
                }
                else
                {
                    medio = y;
                    maior = x;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(medio);
            Console.WriteLine(maior);
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
