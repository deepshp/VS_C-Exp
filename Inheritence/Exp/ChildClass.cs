using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExamples
{
    class ChildClass : BaseClass 
    {
        public ChildClass():base()
        {
            Console.WriteLine("Child class Constructor");

        }
        public new int ChildMul(int a, int b)
        {
            return a*b;
        }
        public int ChildDiv(int a, int b)
        {
            return a / b;
        }
        public void Diplay()
        {
            base.Diplay();
            Console.WriteLine("ChildClass");
        }

        public void NewVar()
        {
            
            Console.WriteLine("NewVar()");
        }

    }
}
