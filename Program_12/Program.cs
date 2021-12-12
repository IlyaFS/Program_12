using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_12
{
    internal class Program
    {
        static void Main(string[] args)
        {      
            Console.WriteLine("Введите радиус окружности R: ");
            Krug.R = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки x0: ");
            Krug.x0 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки y0: ");
            Krug.y0 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки x1: ");
            Krug.x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки y1: ");
            Krug.y1 = int.Parse(Console.ReadLine());
            
            Krug.Perimetr();
            Krug.Square();
            Krug.Point();
            Console.Write("Нажмите на любого клавиша . . .");
            Console.ReadKey();
        }

        static class Krug
        {
            private static double per;
            private static double sq;
            private static double point;
            public static int R { get; set; }
            public static int x0 { get; set; }
            public static int y0 { get; set; }
            public static int x1 { get; set; }
            public static int y1 { get; set; }           

            public static void Perimetr()
            {
                per = 2 * Math.PI * R;
                Console.WriteLine("Периметр окружности равен: {0:0.00}", per);
            }
            public static void Square()
            {
                sq = Math.PI * Math.Pow(R, 2);
                Console.WriteLine("Площадь окружности равна: {0:0.00}", sq);
            }
            public static void Point()
            {
                point = Math.Sqrt((x0 - x1) * (x0 - x1) + (y0 - y1) * (y0 - y1));

                if (point <= R)
                    Console.WriteLine("Точка лежит внутри окружности!");
                else
                    Console.WriteLine("Точка лежит за пределами окружности!");
            }

        }

    }
}
