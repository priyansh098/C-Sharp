using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class While
    {
        public While()
        {
            Console.WriteLine("-------------------While--------------------");
            int n = 5;
            while (n >= 0)
            {
                Console.Write(n + " ");
                n--;
            }
            Console.WriteLine();
        }
    }
}
