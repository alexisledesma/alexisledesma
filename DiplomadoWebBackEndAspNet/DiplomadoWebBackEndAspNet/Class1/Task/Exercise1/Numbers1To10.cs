using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEndAspNet.Class1.Task.Exercise1
{
    public class Numbers1To10
    {
        public void PrintNumbers1To10()
        {
            int i, par = 0;

            for (i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}|", i);
                    par++;
                }
            }
            Console.Write("\n\nDel 0 al 100 hay {0} números pares\n\n", par);
        }


        public void PerfectNumber()
        {
            int sumi = 0;
            Console.WriteLine("Digita un numero entero positivo y presine enter\n");
            int nu = int.Parse(Console.ReadLine());

            for (int i = 1; i < nu; i++)
            {
                if (nu % i == 0)
                {
                    sumi = sumi + i;
                }

            }

            if (sumi == nu)
                Console.WriteLine("El numero es perfecto");
            else
                Console.WriteLine("El numero no es perfecto"); 

        }
    }
}
