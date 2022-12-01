using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0, P = 0, a = 0, b = 0, c = 0;
            do { 
                try
                {
                    Console.Write("Введите x1: ");
                    x1 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Только цифры");
                }
            } while (true);
            do
            {
                try
                {
                    Console.Write("Введите y1: ");
                    y1 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Только цифры");
                }
            } while (true);
            do
            {
                try
                {
                    Console.Write("Введите x2: ");
                    x2 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Только цифры");
                }
            } while (true);
            do
            {
                try
                {
                    Console.Write("Введите y2: ");
                    y2 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Только цифры");
                }
            } while (true);
            do
            {
                try
                {
                    Console.Write("Введите x3: ");
                    x3 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Только цифры");
                }
            } while (true);
            do {
                try
                {
                    Console.Write("Введите y3: ");
                    y3 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Только цифры");
                }
            } while (true);


            a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            b = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            c = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));

            P = a + b + c;

            Console.WriteLine("Периметр треугольника: " + P);
            Console.ReadKey();
        }
    }
}
 
