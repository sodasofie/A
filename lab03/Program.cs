using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    class Program
    {
        static void Main(string[] args)
        {

            int x1,y1,x2,y2;

            Console.WriteLine("Введiть координати 1 коня");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть координати 2 коня");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());

            if (Math.Abs(x2 - x1) + Math.Abs(y2 - y1) == 3 && (x2 - x1) * (y2 - y1) != 0){
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            return;

            Console.ReadLine();
        }

    }
}
