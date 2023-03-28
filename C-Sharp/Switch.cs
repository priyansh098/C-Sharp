using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class Switch
    {
        public Switch()
        {
            Console.WriteLine("-------------------Switch--------------------");
            int No_of_days = 366;
            switch(No_of_days){
                case 365:
                    Console.WriteLine("It's not a Leap Year.");
                    break;
                case 366:
                    Console.WriteLine("It's a Leap Year.");
                    break;
                default:
                    Console.WriteLine("Happy Year.");
                    break;
            }
        }
    }
}
