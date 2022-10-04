using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    class Program
    {
        static void Main(string[] args)
        {
             
              //ВИЙШЛО ЛИШЕ "БІЛЬШЕ 2"

            int n, k;
            Console.Write("Введiть довжину масиву:\t");
            n = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];
            double m;
            Console.WriteLine("Введiть элементи масиву:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + Convert.ToString(i + 1) + "]=");
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            m = 0;
            for (int i = 0; i < n; i++)
            {
                k = 0;
                m = a[i];
                for (int j = 0; j < n; j++)
                {
                    if (a[j] == m)
                    {
                        k = k + 1;
                    }
                    if (k > 2)
                        for (int l = 0; l < a.Length; l++)
                        {
                            if (a[l] == m)
                                Array.Clear(a, l, 1);
                        }
                }
            }
            Console.WriteLine("Змiнений масив:");
            for (int i = 0; i < a.Length; i++)
                if (a[i] != 0) {         
            Console.Write(a[i]);          
                }
            Console.ReadLine();
        }
    }
}


   