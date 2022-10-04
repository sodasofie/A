using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    class Program
    {
        static void Main(string[] args)
        {

            int nn;
            int nk;
            int k;
            double res = 0;

            Console.WriteLine("Введiть початкове ");
            nn = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть кiнцеве ");
            nk = int.Parse(Console.ReadLine());

            for (k = nn; k < nk; k++)
            {
                if (0 <= nn & nn <= nk)
                {
                    res +=( Math.Pow(-1, Math.Pow(k, 2)+1)*Math.Pow(k,2)-2)/(3*Math.Pow(k,3)-2*k);
                        
                }

                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }

            Console.WriteLine(res);
        }

    }
}
