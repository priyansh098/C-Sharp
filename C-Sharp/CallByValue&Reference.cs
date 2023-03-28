using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class CallByValue_Reference
    {
        public CallByValue_Reference()
        {
            Console.WriteLine("-------------------CallByValue_Reference--------------------");
        }
        public int show(int val)
        {
            return val *= val;
        }
        public int show(ref int val)
        {
            return val *= val;
        }
    }
}
