using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите значение длин сторон первого треугольника");
            
            
            do
            {
                Console.WriteLine();
                Console.Write("a= ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b= ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c= ");
                c = Convert.ToDouble(Console.ReadLine());
                 //Console.WriteLine(a + " " + b + " " + c);
                 //Console.WriteLine((a + b > c) + " " + (b + c > a) + " " + (a + c > b));
                bool t = ((a + b > c) && (b + c > a) && (a + c > b));
                //Console.WriteLine(t);
                if (t == false)
                { Console.WriteLine("Такого треугольника не существует, введите новые данные"); }
                else
                    Console.WriteLine("Отлично! Треугольник с такими значениями сторон реален");
                Console.WriteLine();
            }
            while (!(a + b > c) && (b + c > a) && (a + c > b));

            double s1 = CalcTriangle(a, b, c);

            Console.WriteLine("Введите значение длин сторон второго треугольника");
            do
            {
                Console.WriteLine();
                Console.Write("a= ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b= ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c= ");
                c = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine(a + " " + b + " " + c);
                //Console.WriteLine((a + b > c) + " " + (b + c > a) + " " + (a + c > b));
                bool t = ((a + b > c) && (b + c > a) && (a + c > b));
                //Console.WriteLine(t);
                if (t == false)
                { Console.WriteLine("Такого треугольника не существует, введите новые данные"); }
                else
                    Console.WriteLine("Отлично! Треугольник с такими значениями сторон реален");
            }
            while (!(a + b > c) && (b + c > a) && (a + c > b));

            double s2 = CalcTriangle(a, b, c);
            Console.WriteLine();
            Console.WriteLine("Площадь первого треугольника* = {0,4:f2}", s1);
            Console.WriteLine("Площадь второго треугольника* = {0,4:f2}", s2);

            if (s1 == s2)
                Console.WriteLine("Площади треугольников одинаковы");
            else
                if (s1 > s2)
                Console.WriteLine("Площадь первого треугольника больше");
            else
                Console.WriteLine("Площадь второго треугольника больше");
            Console.ReadKey();
        }
        static double CalcTriangle(double a, double b, double c)
        {
            double p = 0;
            double s = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //Console.WriteLine("Площадь треугольника = {0}  {1}", s, p);
            return s;

        }
    }
}
