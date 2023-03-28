using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class ClassObject
    {
        int id; string name;
        public int Id;
        public string Name;
        public float Salary;
        public static double Rate = 5.258D;
        public static int count = 0;
        public int length, breadth;
        private string Fname;
        public string FName
        {
            get
            {
                return Fname;
            }
            set
            {
                Fname = value;
            }
        }
        public enum Dept { d1, d2, d3, d4, d5}; // if you right d1=10, then it starts from 10 instead of 0.
        public void EnumForLoop()
        {
            foreach (string i in Enum.GetNames(typeof(Dept))) { Console.Write(i + " "); }
            Console.WriteLine();
        }
        public void Area()
        {
            Console.WriteLine(length * breadth);
        }
        public ClassObject(int a, string b, float c, int x, int y)
        {
            Id = a;
            Name = b;
            Salary = c;
            this.length = x;
            this.breadth = y;
            count++;
            Console.WriteLine("-------------------ClassObject--------------------");
        }
        ~ClassObject()
        {
            Console.WriteLine("Destructor Invoked");
        }
        public void insert(int num, string str)
        {
            id = num;
            name = str;
            count++;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name);
            Console.WriteLine(Id + " " + Name + " " + Salary + " " + Rate);
            Console.WriteLine(ClassObject.count);
        }
    }
    public static class PGMath
    {
        public static float PI = 3.14f;
        public static int Cube(int n)
        {
            return (n * n * n);
        }
    }
}
