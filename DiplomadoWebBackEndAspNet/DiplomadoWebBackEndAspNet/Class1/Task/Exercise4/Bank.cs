using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEndAspNet.Class1.Task.Exercise4
{
    public class Bank : Customer
    {
        public Bank()
        {

        }

        public void GetDepositTotal() {

            foreach (var item in CustomerList)
            {
                Console.WriteLine("El cliente '{0}' tiene un monto depositado de :'{1}'.\n",item.Name,item.Amount);
            }
        }
    }
}
