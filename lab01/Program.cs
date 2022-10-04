using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обчислення об'єму цилiндра: ");
            Console.Write("Введiть радiус = ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введiть висоту = ");
            double h = Convert.ToDouble(Console.ReadLine());
            
            double pi = Math.PI;
            double v = pi *  Math.Pow(r,2) * h;
               

            Console.WriteLine("Об'єм цилiндра = " + v );


            Console.ReadLine();
        }

    }
}
