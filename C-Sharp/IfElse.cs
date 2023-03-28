using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class IfElse
    {
        public IfElse()
        {
            Console.WriteLine("-------------------IfElse--------------------");
            int age1 = 15, age2 = 21, age3 = 65;
            //If-Else
            if (age1 >= 18) Console.WriteLine("You're an Adult.");
            else Console.WriteLine("You're not an Adult.");
            //If-Elseif-Else
            if (age2 < 60) Console.WriteLine("Your age is below 60.");
            else if (age2 == 60) Console.WriteLine("You are 60 year old.");
            else Console.WriteLine("Your age is above 60");
            //Nested If-Else.
            if (age3 >= 18)
            {
                if(age3<60) Console.WriteLine("Your age is below 60.");
                else Console.WriteLine("Your age is above 60");
            }
        }
    }
}
