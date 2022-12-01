using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лин.алг._2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                char[] a;
                char[] check;
                do
                {
                    try
                    {
                        Console.Write("Введите двух значное число: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        string c = Convert.ToString(b);
                        check = c.ToCharArray();
                        if (check.Length <= 3)
                        {
                            if (check[0] == '-')
                            {
                                a = check;
                                break;
                            }
                            else if(check.Length == 2)
                            {
                                a = check;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Не двухзначное");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Число не двухзначное");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Только цифры");
                    }

                } while (true);
                if (a.Length ==3 && (int.Parse(a[1].ToString()) + int.Parse(a[2].ToString())) % 3 == 0) Console.WriteLine("кратно ");
                else if(a.Length == 3) Console.WriteLine("не кратно ");
                else if (a.Length==2 && (int.Parse(a[0].ToString()) + int.Parse(a[1].ToString()) % 3 == 3)) Console.WriteLine("кратно");
                else if (a.Length == 2 ) Console.WriteLine("не кратно");
            } while (true);
        }
    }
}
