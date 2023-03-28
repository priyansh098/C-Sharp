using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class ForLoop
    {
        public ForLoop()
        {
            Console.WriteLine("-------------------ForLoop--------------------");
            int n = 10;
            //Normal For Loop
            for (int i = 0; i < n; i++) Console.Write(i + " ");
            Console.WriteLine();
            
            //Nested For Loop
            for (int i = 0; i < n/2; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }
            //Infinite For Loop
            //for (; ; ) Console.WriteLine("Hello.");
        }
    }
}
