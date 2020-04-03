using System;
using System.Globalization;

namespace uri1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = 3.0;
            double volume;
            double pi = 3.14159;

            R = double.Parse(Console.ReadLine());
            volume = (4 * pi * Math.Pow(R, 3) / 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3"));
        }
    }
}