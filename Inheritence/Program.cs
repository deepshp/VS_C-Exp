using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
     class Program
    {

        static void Main(string[] args)
        {
            //VirtualOverideExp();
            New_WithoutOR_WithNewKeyWord();
            
            Console.ReadKey();
        }
        static void New_WithoutOR_WithNewKeyWord()
        {
            // we same name method in child class and Base class

            // I bege to situation ,System skal call till child class funktion
            Console.WriteLine("Inheritence Experiment----NEW");


            ChildClass ccObj = new ChildClass();
            // call  to function of childClass 
            ChildClass childObj = new ChildClass();
            BaseClass baseObj = new ChildClass();
            // call  to function of childClass 

            childObj.newExp();
            baseObj.newExp();
        }
        static void VirtualOverideExp()
        {
            // we same name method in child class and Base class


            Console.WriteLine("Inheritence Experiment---Virtual --Override");

            ChildClass childObj = new ChildClass();
            BaseClass baseObj = new ChildClass();
            // call  to function of childClass 
           
            childObj.baseOverride();
            baseObj.baseOverride();


            

        }
    }
}
