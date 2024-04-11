using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Выберите тип уравнения (напишите цифру)");
            Console.WriteLine("1. Квадратное");
            Console.WriteLine("2. Биквадратное ");
            Console.Write("Тип уравнения : ");
            string Ty = (Console.ReadLine()).ToString();

            if (Ty == "1")
            {
                Console.WriteLine("Введите a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите c: ");
                c = int.Parse(Console.ReadLine());

                float D = (float)((b * b) - (4 * a * c));
                float X1 = (float)(-b + (Math.Sqrt(D)) / (2 * a));
                float X2 = (float)(-b - (Math.Sqrt(D)) / (2 * a));

                if (X1 == 0 && X2 == 0) { Console.WriteLine("x = 0"); }
                else if (X1 > 0 || X2 > 0)
                {
                    Console.WriteLine("x1 = " + X1);
                    Console.WriteLine("x2 = " + X2);
                }
                else { Console.WriteLine("x < 0"); }
            }
            else if (Ty == "2")
            {
                Console.WriteLine("Введите a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите c: ");
                c = int.Parse(Console.ReadLine());



                float D = (float)((b * b) - (4 * a * c));
                float X11 = (float)(-b + (Math.Sqrt(D)) / (2 * a));
                float X12 = (float)(-b - (Math.Sqrt(D)) / (2 * a));
                float X1 = (float)(Math.Sqrt(X11));
                float X2 = (float)(Math.Sqrt(X12));

                if (X1 == 0 && X2 == 0) { Console.WriteLine("x = 0"); }
                else if (X1 > 0 || X2 > 0)
                {
                    Console.WriteLine("x1 = " + X1);
                    Console.WriteLine("x2 = " + X2);
                }
                else { Console.WriteLine("x < 0"); }
            }
            else { Console.WriteLine("Введите корректное число"); }

            Console.ReadLine();
        }
    }
}
