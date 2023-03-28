using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class Function
    {
        public Function()
        {
            Console.WriteLine("-------------------Functions--------------------");
        }
        public void show()
        {
            Console.WriteLine("It is a Function.");
        }
        public string show(string str)
        {
            string val = $"Hello, {str}";
            return val;
        }
    }
}
