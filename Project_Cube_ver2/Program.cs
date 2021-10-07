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
            double v = Cube(d,1);
            double s = Cube(d,2);
            Console.WriteLine("Площадь поверхности куба = {0,3:f2} ", s);
            Console.WriteLine("Объем куба = {0,3:f2} ", v);
            Console.ReadKey();

        }
        static double Cube(double a, int x)
        {
            double v;
            if (x == 1)                            // для вычисления объема
                v = Math.Pow(a, 3);
            else
            if (x == 2)                             // для вычисления площади поверхности
                v = 6 * Math.Pow(a, 2);
            else
                v = 0;
           return v;
            
        }
    }
}
