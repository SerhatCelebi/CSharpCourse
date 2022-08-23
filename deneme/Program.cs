sing System;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager person=new PersonManager();
            Customer customer=new Customer
            {
                ID = 1,
                Name = "Sero",
                LastName = "Kero",
                
            };
            Worker worker = new Worker
            {
                ID = 2,
                Name = "Fero",
                LastName = "Hero"
            };

            person.Addle(customer);
            person.Addle(worker);
            Console.ReadLine();
        }
    }

    interface IPerson
    {
        int ID { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
    }

    class Customer:IPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        
    }

    class Worker:IPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }

    class PersonManager
    {
        public void Addle(IPerson person)
        {
            Console.WriteLine(person.ID);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.LastName);
        }
    }
}
