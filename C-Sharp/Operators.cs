using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class Operators
    {
        public Operators()
        {
            Console.WriteLine("-------------------Operators--------------------");
            int x = 10, y = 5; bool z = false;
            //Arithmetic Operators
            int a = (x + y), b = (x - y), c = (x * y), d = (x % y), e = (x / y);
            Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);
            //Relational Operators
            if (x > y) { Console.WriteLine($"{x} is greater than {y}"); } // also use <= , >=.
            if (y < x) { Console.WriteLine($"{y} is smaller than {x}"); }
            if (b == y) { Console.WriteLine($"{b} is equal to {y}"); }  
            if (x != y) { Console.WriteLine($"{x} is not equal to {y}"); }
            //Logical Operators
            if ((x > y) && (y < x)) Console.WriteLine("True");
            if ((x > y) || (y > x)) Console.WriteLine("True");
            if (!z) Console.WriteLine("False");
            //Bitwise Operators
            int a1 = 1 & 0, a2 = 1 | 0, a3 = 1 ^ 0, a4 = 5 >> 1, a5 = 10 >> 1, a6 = 5 << 1, a7 = 10 << 1;
            Console.WriteLine(a1 + " " + a2 + " " + a3 + " " + a4 + " " + a5 + " " + a6 + " " + a7);
            //Unary Operators
            Console.WriteLine(x++ + " " + ++y + " " + x);
            //Null Coalescing
            string? str1 = null, str2 = "PG";
            string str3 = str1 ?? str2;
            Console.WriteLine(str3);
            int? num1 = null, num2 = 25;
            int? num3 = num1 ?? num2;
            Console.WriteLine(num3);
            //Ternary Operators
            string val = (x > y) ? $"{x} is greater than {y}" : $"{x} is smaller than {y}";
            Console.WriteLine(val);
            //Assignment Operators
            a += a; b -= b; c *= c; x %= x; e /= e;
            Console.WriteLine(a + " " + b + " " + c + " " + x + " " + e);
        }
    }
}
