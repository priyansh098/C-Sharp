using C_Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_Sharp.ClassObject;

class Program
{
    public static void Main(string[] args)
    {
        HelloWorld obj1 = new HelloWorld();
        Variables_DataTypes obj2 = new Variables_DataTypes();
        Operators obj3 = new Operators();
        IfElse obj4 = new IfElse();
        Switch obj5 = new Switch();
        ForLoop obj6 = new ForLoop();
        While obj7 = new While();
        DoWhile obj8 = new DoWhile();
        Break_Continue_Goto obj9 = new Break_Continue_Goto();
        /*-------------------------------------------------------------------*/
        Function obj10 = new Function();
        obj10.show();
        Console.WriteLine(obj10.show("Priyansh."));
        int val = 5;
        CallByValue_Reference obj11 = new CallByValue_Reference();
        Console.WriteLine($"Before: {val}" + " " + $"Show: {obj11.show(val)}" + " " + $"After: {val}");
        Console.WriteLine($"Before: {val}" + " " + $"Show: {obj11.show(ref val)}" + " " + $"After: {val}");
        Arrays obj12 = new Arrays();
        obj12.show(10, 15, 12, 14, 17);
        obj12.show("Priyansh", 10, 52.36, 25.0006, 'P', true);
        ClassObject obj13 = new ClassObject(1,"PG",20000,5,6);
        obj13.insert(101, "Priyansh");
        obj13.display();
        Console.WriteLine(PGMath.PI + " " + PGMath.Cube(4));
        obj13.Area();
        Console.WriteLine((int)Dept.d5 + " " + (int)Dept.d3);
        obj13.EnumForLoop();
        obj13.FName = "Hello, Priyansh";
        Console.WriteLine(obj13.FName);
        Inheritance3 obj14 = new Inheritance3();
        obj14.Me(); obj14.Father(); obj14.GrandFather();
        Aggregation obj15 = new Aggregation("Gupta", "Firozabad");
        Aggregation2 obj16 = new Aggregation2(1, "Priyansh", obj15);
        obj16.display();
        Polymorphism3 obj17 = new Polymorphism3();
        Polymorphism obj18 = new Polymorphism();
        Console.WriteLine(Polymorphism.Add(5,6));
        Console.WriteLine(Polymorphism.Add(5.65f,9.65f));
        Console.WriteLine(Polymorphism.Add("Hello","Priyansh"));
        Polymorphism2 obj19 = new Polymorphism2();
        obj19.show(); obj19.Display();
        Console.WriteLine("-------------------Abstraction--------------------");
        Abstraction obj20;
        obj20 = new Abstract1(); obj20.show();
        obj20 = new Abstract2(); obj20.show();
        Interface obj21;
        obj21 = new Interface2(); obj21.Display();
        obj21 = new Interface3(); obj21.Display();




    }
}