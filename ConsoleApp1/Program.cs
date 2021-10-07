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
            bool t;
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
                t = Verify(a, b, c);
            }
            while (!t);
            double s1 = CalcTriangle(a, b, c);
            Console.WriteLine();
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
                t = Verify(a, b, c);
            }
            while (!t);

            double s2 = CalcTriangle(a, b, c);
            Console.WriteLine();
            Console.WriteLine("Площадь первого треугольника = {0,4:f2}", s1);
            Console.WriteLine("Площадь второго треугольника = {0,4:f2}", s2);
            Compare(s1, s1);
            //if (s1 == s2)
            //    Console.WriteLine("Площади треугольников одинаковы");
            //else
            //    if (s1 > s2)
            //    Console.WriteLine("Площадь первого треугольника больше");
            //else
            //    Console.WriteLine("Площадь второго треугольника больше");
            Console.ReadKey();
        }
        static bool Verify(double a, double b, double c)
        {
            bool t = ((a + b > c) && (b + c > a) && (a + c > b));               // проверка на корректность ввода данных
            if (t == false)
            { Console.WriteLine("Такого треугольника не существует, введите новые данные"); }
            else
                Console.WriteLine("Отлично! Треугольник с такими значениями сторон реален");
            return t;
        }

        static double CalcTriangle(double a, double b, double c)
        {
            double p = 0;
            double s = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));  // расчет площади треугольника
            return s;
        }

        static string Compare(double s1, double s2)
        {
            string Text = "";
            if (s1 == s2)
                Text="Площади треугольников одинаковы";
            else
                if (s1 > s2)
                Text = "Площадь первого треугольника больше";
            else
                Text = "Площадь второго треугольника больше";
            Console.WriteLine(Text);
            return Text;
        }
    }
}
