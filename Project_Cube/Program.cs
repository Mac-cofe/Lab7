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
            double v = Cube_v(d);
            double s = Cube_s(d);
            Console.WriteLine("Площадь поверхности куба = {0,3:f2} ", s);
            Console.WriteLine("Объем куба = {0,3:f2} ", v);
            Console.ReadKey();

        }
        static double Cube_v(double a)
        {
            double v = Math.Pow(a, 3);
            return v;
        }
        static double Cube_s(double a)
        {
            double s = 6 * Math.Pow(a, 2);
            return s;
        }
    }
}
