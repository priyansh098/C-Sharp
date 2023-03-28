using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class Break_Continue_Goto
    {
        public Break_Continue_Goto()
        {
            Console.WriteLine("-------------------Break_Continue_Goto--------------------");
            int n = 10;
            for(int i=0; i<n; i++)
            {
                if (i == 2) continue;
                else if (i == 8) break;
                else Console.Write(i + " ");
            }
            Console.WriteLine();
            if (n == 10) goto val;
            val:
                Console.WriteLine("Goto");
        }
    }
}
