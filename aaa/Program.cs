using System;
using System.Collections;
using System.Collections.Generic;

namespace aaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList cities2 = new ArrayList();
            cities2.Add("Zonguldak");
            cities2.Add("Ankara");
            cities2.Add("Rize");
            cities2.Add(3);
            List<string> sehirler = new List<string>();
            sehirler.Add("abc");
            sehirler.Add("def");
            sehirler.Add("ghi");
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
            foreach (var city2 in cities2)
            {
                Console.WriteLine(city2);
            }
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, Name = "Aaaa" });
            customers.Add(new Customer { Id = 2, Name = "Bbbb" });
            customers.Add(new Customer { Id = 3, Name = "Cccc" });
            customers.Add(new Customer { Id = 4, Name = "Dddd" });
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
        class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
