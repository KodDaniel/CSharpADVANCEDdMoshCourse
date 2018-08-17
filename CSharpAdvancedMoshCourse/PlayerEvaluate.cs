using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedMoshCourse
{
    class PlayerEvaluate
    {
        public void Salary(Player player,int salary)
        {
            Console.WriteLine("The {0} has the salary {1}.",player,salary);
        }

        public void Age(Player player, int age)
        {
            Console.WriteLine("{0} are {1} years old.",player, age);
        }

        
    }
}
