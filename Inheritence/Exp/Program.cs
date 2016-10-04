using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExamples
{
    class Program
    {
        static void MainInherit(string[] args) 
        {
            Console.WriteLine("Inheritence");

            ChildClassOth ccObj = new ChildClassOth();
            NewVarExp();
            //call to base class
            //ccObj.BaseMul(3,4);

           // ccObj.Diplay();
                
           // BaseClass bbObj = new  ChildClass();

            //sint result=ccObj.AddMul(2, 3);
           // result = bbObj.AddMul(5, 2);
            //result = bbObj.BaseMul(5,2);
            //Console.WriteLine(result);
            Console.ReadKey();

        }

        static void NewVarExp()
        {
            ChildClassOth ccObj = new ChildClassOth();
            BaseClass bbObj = new  ChildClassOth();

        }
    }
}
