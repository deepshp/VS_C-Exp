using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class BaseClass
    {

        public int baseAdd(int a,int b)
        {
            return a+b;
        }

        public virtual void baseOverride()
        {
            Console.WriteLine("Base Overide");
        }
        public  void newExp()
        {
            Console.WriteLine("Base new");
        }
    }
}
