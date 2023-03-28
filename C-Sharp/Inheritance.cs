using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class Inheritance
    {
        public Inheritance()
        {
            Console.WriteLine("-------------------Inheritance--------------------");
        }
        public void GrandFather()
        {
            Console.WriteLine("GrandFather's Quality");
        }
    }
    public class Inheritance2 : Inheritance
    {
        public void Father()
        {
            Console.WriteLine("Father's Quality");
        }
    }
    public class Inheritance3 : Inheritance2
    {
        public void Me()
        {
            Console.WriteLine("My Qualities.");
        }
    }
    public class Aggregation
    {
        public string surname, city;
        public Aggregation(string str, string str2)
        {
            this.surname = str;
            this.city = str2;
        }
    }
    public class Aggregation2
    {
        public int id; public string firstname; public Aggregation agr;
        public Aggregation2(int a, string str3, Aggregation agr)
        {
            this.id = a;
            this.firstname = str3;
            this.agr = agr;
        }
        public void display()
        {
            Console.WriteLine(id + " " + firstname + " " + agr.surname + " " + agr.city);
        }
    }
}
