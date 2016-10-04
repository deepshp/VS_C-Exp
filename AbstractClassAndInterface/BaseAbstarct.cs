using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndInterface
{
    abstract class  BaseAbstarct
    {
        public BaseAbstarct()
        {

        }
        public abstract void abstractMethod();
        public void GetAbstractClass()
        {

        }
    }
     class ChildClass :BaseAbstarct
    {
        public override void abstractMethod()
        {
            throw new NotImplementedException();
        }

       

        public void GetAbstractClass()
        {

        }
    }
}
