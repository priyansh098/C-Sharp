using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class Polymorphism3
    {
        public Polymorphism3()
        {
            Console.WriteLine("-------------------Polymorphism--------------------");
        }
    }
    public class Polymorphism
    {
        public string str = "Hello, I'm Polymorphism";
        public virtual void show()
        {
            Console.WriteLine("I'm Virtual Show.");
        }
        public static int Add(int a, int b)
        {
            return (a+b);
        }
        public static float Add(float a, float b)
        {
            return (a+b);
        }
        public static string Add(string str1, string str2)
        {
            return (str1 + ", " + str2);
        }
    }
    public class Polymorphism2 : Polymorphism
    {
        public string str = "Hello, I'm Polymorphism2";
        public void Display()
        {
            Console.WriteLine(base.str);
            Console.WriteLine(str);
        }
        public override void show()
        {
            base.show(); // If you want to use override function, comment this line.
            Console.WriteLine("I'm Override Show.");
        }
    }
}
