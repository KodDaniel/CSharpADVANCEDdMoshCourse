using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 10;
            var cut = new Customer();

            List<Customer> customers = Customer.GetAllCustomers();
            foreach (Customer customer in customers)
            {
                Console.WriteLine("First Name = {0} & Last Name = {1}",
                    customer.FirstName, customer.LastName);
            }

        }
        class Customer
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }
            public int Salary { get; set; }

            public static List<Customer> GetAllCustomers()
            {
            List<Customer> listCustomers = new List<Customer>();

            Customer customer1 = new Customer{ID = 101, FirstName = "Mark", LastName = "Scotts",Gender = "Male",Salary = 55000};

            Customer customer2 = new Customer{ID = 102,FirstName = "Steve", LastName = "Wicht",Gender = "Male", Salary = 45000};

            Customer customer3 = new Customer {ID = 103, FirstName = "Pam",LastName = "P", Gender = "Female", Salary = 65000};

            Customer customer4 = new Customer{ID = 104, FirstName = "Todd",LastName = "Snider", Gender = "Male", Salary = 45000};

            Customer customer5 = new Customer{ID = 105,FirstName = "Valarie",LastName = "Ward", Gender = "Female",Salary = 35000};

                listCustomers.Add(customer1);
                listCustomers.Add(customer2);
                listCustomers.Add(customer3);
                listCustomers.Add(customer4);
                listCustomers.Add(customer5);

                return listCustomers;
            }
        }
    }





}

