using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet4Q6_Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 6");
            string[] names = { "Mary", "Joseph", "Micheal", "Sarah", "Margaret", "John" };

            var query1a = from item in names
                        select item;

            Console.WriteLine("All the names (Query) : ");
            foreach (var item in query1a)
            {
                Console.WriteLine(item);
            }


            var query1b = names.Select(n => n);

            Console.WriteLine("All the names (Lambda) : ");
            foreach (var item in query1b)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n\nQuestion 7");

            

            var query2a = from item in names
                          orderby item ascending
                          select item;

            var query2b = names.OrderBy(n => n);

            Console.WriteLine("All the names ordered alphabetically (Query)");

            foreach (var item in query2a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("All the names ordered alphabetically (Query)");

            foreach (var item in query2b)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n\n\nQuestion 8");



            var query3a = from item in names
                          where item[0] == 'M'|| item[0] == 'm'
                          select item;

            var query3b = names.Where(n => n[0] == 'M' || n[0] == 'm');

            Console.WriteLine("All the names starting with M (Query)");

            foreach (var item in query3a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("All the names starting with M (Lambda)");

            foreach (var item in query3b)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n\n\nQuestion 9");

            List<Customer> customerList = GetCustomers();


            var query4a = from item in customerList
                          where item.City == "Dublin"
                          select item.Name;

            var query4b = customerList.Where(n => n.City == "Dublin");

            Console.WriteLine("All the customers living in Dublin (Query)");

            foreach (var item in query4a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("All the customers living in Dublin (Lambda)");

            foreach (var item in query4b)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n\nQuestion 10");

           


            var query5a = from item in customerList
                          where item.City == "Dublin" || item.City =="Galway"
                          orderby item.Name
                          select item.Name;

            var query5b = customerList.Where(n => n.City == "Dublin" || n.City == "Galway").OrderBy(n => n.Name).Select(n => n.Name);
               
            

            Console.WriteLine("All the customers living in Dublin or Galway ordered by Name (Query)");

            foreach (var item in query5a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("All the customers living in Dublin or Galway ordered by Name (Lambda)");

            foreach (var item in query5b)
            {
                Console.WriteLine(item);
            }
        }

        private static List<Customer> GetCustomers()
        {
            Customer c1 = new Customer { Name = "Tom", City = "Dublin" };
            Customer c2 = new Customer { Name = "Sally", City = "Galway" };
            Customer c3 = new Customer { Name = "George", City = "Cork" };
            Customer c4 = new Customer { Name = "Molly", City = "Dublin" };
            Customer c5 = new Customer { Name = "Joe", City = "Galway" };

            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            customers.Add(c5);

            return customers;
        }
    }
}
