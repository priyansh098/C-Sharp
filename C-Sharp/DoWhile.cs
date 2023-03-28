using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class DoWhile
    {
        public DoWhile()
        {
            Console.WriteLine("-------------------DoWhile--------------------");
            int n = 5;
            do
            {
                Console.Write(n + " ");
                n--;
            }while(n >= 0);
            Console.WriteLine();
        }
    }
}
