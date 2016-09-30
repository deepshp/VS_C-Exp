using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExamples
{
    class A
    {
        public virtual void show()
        {
            Console.WriteLine("Hello: Base Class!");
       //     Console.ReadLine();
        }
    }

    class B : A
    {
        public override void show()
        {
            Console.WriteLine("Hello: Derived Class!");
           // Console.ReadLine();
        }
    }

    class Polymorphism
    {
        public static void Main()
        {
            Console.WriteLine("Virtual Override");
            A a1 = new A();
            a1.show();
            B b1 = new B();
            b1.show();
            A a2 = new B();
            a2.show();
        }
    }
}
