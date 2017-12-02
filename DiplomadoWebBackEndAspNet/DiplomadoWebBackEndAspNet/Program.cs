using DiplomadoWebBackEndAspNet.Class1.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEndAspNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuTask = new MenuTask();

            menuTask.GetMenuTask();

            Console.ReadKey();
        }
    }
}
