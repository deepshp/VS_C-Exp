using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class ChildClass : BaseClass 
    {
        public new int baseAdd(int a, int b)
        {
            return a*b;
        }

        //Experiment for Override
        /* if base class methods will mark with override ,virtual and abstarct
         * 
         * then system will create error
         *   Can override on inherhit method
        */
        public override void baseOverride()
        {
            Console.WriteLine("Child Overide");
            //base.baseOverride();
        }
        public  void baseOverride2()
        {
            Console.WriteLine("Child  new Overide");
        }
        public void newExp()
        {
            Console.WriteLine("Child new");
        }
    }
}
