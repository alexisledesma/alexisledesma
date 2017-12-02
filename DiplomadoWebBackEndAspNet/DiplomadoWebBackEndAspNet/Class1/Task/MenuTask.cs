using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiplomadoWebBackEndAspNet.Class1.Task.Exercise4;

namespace DiplomadoWebBackEndAspNet.Class1.Task
{
    public class MenuTask
    {


        public void GetSelecct(int opction)
        {
            switch (opction)
            {
                case 1:
                    Console.Clear();
                    GetMenuTask1();
                    break;
                case 2:
                    Console.WriteLine("Tarea 2");
                    break;
                default:
                    GetSelecctZero();
                    break;
            }
        }

        public void GetSelecctZero()
        {
            Console.WriteLine("Opcion incorrecta preciones 0 para volver al menu principal");
            var line = int.Parse(Console.ReadLine());


            switch (line)
            {
                case 0:
                    Console.Clear();
                    GetMenuTask();
                    break;
                case 9:
                    Console.Clear();
                    GetMenuTask1();
                    break;
                default:
                    GetSelecctZero();
                    break;
            }
        }

        public void GetMenuTask()
        {
            Console.WriteLine("Ingrese el numero de la tarea quiere visualizar y luego presiones enter.\n");
            Console.WriteLine("1. Tarea 1\n");
            Console.WriteLine("2. Terea 2\n");
            GetSelecct(int.Parse(Console.ReadLine()));
        }

        public void GetMenuTask1()
        {
            Console.WriteLine("Ingrese el numero del ejercicio quiere ejecutar y luego presiones enter.\n");
            Console.WriteLine("\n1. ejercicio 1: ");
            Console.WriteLine("\n2. ejercicio 2: ");
            Console.WriteLine("\n4. ejercicio 4: ");
            Console.WriteLine("\n5. ejercicio 5: ");
            GetSelecctExercise(int.Parse(Console.ReadLine()));
        }
        public void GetMenuExercise4()
        {
            Console.WriteLine("Ingrese el numero del ejercicio quiere ejecutar y luego presiones enter.\n");
            Console.WriteLine("\n 1. Ver lista de deposito: ");
            Console.WriteLine("\n 2. Depositar: ");
            Console.WriteLine("\n 4. Retirar : ");

            Exercise4.Bank exercise4 = new Exercise4.Bank();
            int count = 1;

            switch ((int)int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.Clear();
                    exercise4.GetDepositTotal();
                    GetMenuFooter();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Ingrese el numero del cliente al que le desea hacer el deposito y luego presiones enter.\n");
                    foreach (var item in exercise4.CustomerList)
                    {
                        Console.WriteLine("\n {0}. '{1}'.", count, item.Name);
                        count++;
                    }
                    count = 1;
                    var id = (int)int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el monto a depositar: ");
                    GetExtracthAmount(exercise4, id);
                    break;
                case 3:
                    Console.Clear();
                    GetExtracth(exercise4);
                    break;
                case 0:
                    Console.Clear();
                    GetMenuTask();
                    break;
                case 9:
                    Console.Clear();
                    GetMenuTask1();
                    break;
                default:
                    GetSelecctZero();
                    break;
            }
        }

        private void GetExtracthAmount(Bank exercise4, int lin)
        {
            var amoun = (decimal)decimal.Parse(Console.ReadLine());
            exercise4.Deposit(lin, amoun);
            Console.WriteLine("El deposito se realizo sastifactoriamente.");
            Console.WriteLine("digite 0 para ver lista de deposito: ");
            if ((int)int.Parse(Console.ReadLine()) == 0)
                exercise4.GetDepositTotal();
            GetMenuFooter();
        }

        private void GetExtracth(Bank exercise4)
        {
            int id;
            decimal amouns;
            GetExtracth(exercise4.CustomerList, out id, out amouns);
            int result = exercise4.Extract(id, amouns);
            if (result == 0)
            {
                Console.WriteLine("El retiro se realizo sastifactoriamente.");
                Console.WriteLine("digite 0 para ver lista de deposito: ");
                if ((int)int.Parse(Console.ReadLine()) == 0)
                    exercise4.GetDepositTotal();
                GetMenuFooter();
            }
            else if (result == 1)
            {
                Console.WriteLine("No se encontro ningun cliente con el numero proporcionado.");
                GetExtracth(exercise4);
            }else if (result == 2)
            {
                Console.WriteLine("El cliente seleccionado no posee saldo suficiente para realizar este retiro.");
                GetExtracth(exercise4);
            }
        }

        private void GetExtracth(List<CustomerList> customerList, out int id, out decimal amouns)
        {
            int count = 1;
            Console.WriteLine("Ingrese el numero del cliente al que le desea hacer el retiro y luego presiones enter.\n");
            foreach (var item in customerList)
            {
                Console.WriteLine("\n {0}. '{1}'.", count, item.Name);
                count++;
            }

            id = (int)int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el monto a retirar: ");
            amouns = (decimal)decimal.Parse(Console.ReadLine());
        }


        public void GetMenuFooter()
        {
            Console.WriteLine("Presione 0 para volver al menu principan o 9 para seleccionar un nuevo ejercicio.\n");
            GetSelecctExercise(int.Parse(Console.ReadLine()));
        }
        public void GetSelecctExercise(int opction)
        {
            Exercise1.Numbers1To10 exercise1 = new Exercise1.Numbers1To10();
            Exercise4.Bank exercise4 = new Exercise4.Bank();

            switch (opction)
            {
                case 1:
                    Console.Clear();
                    exercise1.PrintNumbers1To10();
                    GetMenuFooter();
                    break;
                case 2:
                    Console.Clear();
                    exercise1.PerfectNumber();
                    GetMenuFooter();
                    break;
                case 4:
                    Console.Clear();
                    GetMenuExercise4();
                    GetMenuFooter();
                    break;
                case 5:
                    Console.Clear();
                    Class1.Task.Exercise5.DisplayClass.GeometricFiguresDisplay();
                    GetMenuFooter();
                    break;
                case 0:
                    Console.Clear();
                    GetMenuTask();
                    break;
                case 9:
                    Console.Clear();
                    GetMenuTask1();
                    break;
                default:
                    GetSelecctZero();
                    break;
            }
        }
    }
}
