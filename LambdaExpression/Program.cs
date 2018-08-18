using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));
            Console.ReadLine();







        }
    }
}
