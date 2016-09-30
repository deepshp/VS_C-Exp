using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExamples
{
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Base class Constructor"); 

        }
        public virtual int BaseAdd(int a, int b)
        {
            return a + b;
        }
        public  int BaseMin(int a, int b)
        {
            return a + b;
        }
        public void Diplay()
        {
            Console.WriteLine("BaseClass");
        }
        public void NewVar()
        {

            Console.WriteLine("NewVar()");
        }
    }
}
