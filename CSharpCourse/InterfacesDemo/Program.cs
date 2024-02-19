using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()

            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine();
        }

        public void GetSalary()
        {
            Console.WriteLine();
        }

        public void Work()
        {
            Console.WriteLine();
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine();
        }

        public void GetSalary()
        {
            Console.WriteLine();
        }

        public void Work()
        {
            Console.WriteLine();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine();
        }
    }
}














