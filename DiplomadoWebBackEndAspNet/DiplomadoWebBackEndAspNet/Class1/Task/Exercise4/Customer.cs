using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEndAspNet.Class1.Task.Exercise4
{
    public class Customer
    {
        public Customer()
        {
            this.CustomerList.Add(new CustomerList { Id = 1, Name = "Mario Nuñez", Amount = 390 });
            this.CustomerList.Add(new CustomerList { Id = 2, Name = "Juan Lopez", Amount = 800 });
            this.CustomerList.Add(new CustomerList { Id = 3, Name = "Maria contreras", Amount = 1280 });
        }
        public List<CustomerList> CustomerList { get; set; } = new List<CustomerList>();
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }

        public void Deposit(int id, decimal amount)
        {

            var customer = CustomerList.FirstOrDefault(x => x.Id == id);

            if (customer != null)
            {
                customer.Amount += amount;
            }
        }

        public short Extract(int id, decimal amount)
        {
            var customer = CustomerList.FirstOrDefault(x => x.Id == id);
            if (customer != null)
            {
                if (customer.Amount >= amount)
                {
                    customer.Amount -= amount;
                }
                else
                    return 2;
            }
            else
                return 2;

            return 0;
        }
        public void ReturnAmount(int id, decimal amount)
        {
            this.Deposit(id, amount);
        }
    }
    public class CustomerList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
