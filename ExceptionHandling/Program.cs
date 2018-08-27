using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var calculator = new Calculator();
                Console.WriteLine(calculator.divide(5, 0));
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, an exception occured.");
                Console.ReadLine();
            }
            finally
            {

            }

        }


        
    }
}
