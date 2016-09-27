using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Interface
{
    class MainInterface
    {
        public static void Main()
        {
            IGenericInterface<int> clasFronObj = new ClassForInterface<int>();

            clasFronObj.AddData(2,5);
            Console.ReadKey();

        } 
    }
}
