using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C_Sharp
{
    public abstract class Abstraction
    {
        public abstract void show();
    }
    public class Abstract1 : Abstraction
    {
        public override void show()
        {
            Console.WriteLine("Abstract1");
        }
    }
    public class Abstract2 : Abstraction
    {
        public override void show()
        {
            Console.WriteLine("Abstract2");
        }
    }
    public interface Interface
    {
        void Display();
    }
    public class Interface2 : Interface
    {
        public void Display()
        {
            Console.WriteLine("Interface2");
        }
    }
    public class Interface3 : Interface
    {
        public void Display()
        {
            Console.WriteLine("Interface3");
        }
    }
}
