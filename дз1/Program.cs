 using System;

namespace дз1
{
    class Program
    {
        static void Main(string[] args)
        {
           double x, y, z;
            Console.WriteLine("Введите число x");
            x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите чиcло y");
            y = Double.Parse(Console.ReadLine());
            z = Math.Sqrt(Math.Pow((2 + y), 2) + Math.Pow(Math.Sin(y + 5), 1 / 7)) / Math.Log(x + 1) - Math.Pow(y, 3);
            Console.WriteLine("z={0:F2}", z);
        }
`    }
}
