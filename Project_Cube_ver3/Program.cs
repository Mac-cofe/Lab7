using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение длину ребра куба");
            double d = Convert.ToDouble(Console.ReadLine());
            double v;
            double s;
            Cube(d, out v, out s);
            Console.WriteLine("Площадь поверхности куба = {0,3:f2} ", s);
            Console.WriteLine("Объем куба = {0,3:f2} ", v);
            Console.ReadKey();

        }

        static double Cube(double a, out double v, out double s)
        {
            v = Math.Pow(a, 3);
            s = 6 * Math.Pow(a, 2);
            return s;
        }

    }
}
