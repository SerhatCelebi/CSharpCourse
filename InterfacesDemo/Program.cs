using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
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

            IEat[] eats=new IEat[2]
            {
                new Worker(), 
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            ISalary[] salaires = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var salary in salaires)
            {
                salary.GetSalary();
            }

            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();
    }
    //SOLID, Interface Segregation
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
            Console.WriteLine("manager icinde Yedim");
        }

        public void GetSalary()
        {
            Console.WriteLine("manager icinde maas");
        }

        public void Work()
        {
            Console.WriteLine("manager icinde calistim");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("worker icinde Yedim");
        }

        public void GetSalary()
        {
            Console.WriteLine("worker icinde maas");
        }

        public void Work()
        {
            Console.WriteLine("work icinde calistim");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("robot icinde calistim");
        }
    }
}
