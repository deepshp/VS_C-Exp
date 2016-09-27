using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {

           print();// print name for exp
            Add(); // add exp
            Console.ReadKey();

        }
        static void print()
        {

            Basic.GenericClass<int> genObj = new Basic.GenericClass<int>(10);

            genObj.PrintName();
            Console.ReadKey();

        }
        static void Add()
        {

            Basic.GenericClass<int> genObj = new Basic.GenericClass<int>(5);

            genObj.Add(2,3);
            Console.ReadKey();

        }
    }
}
