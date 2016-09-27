using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Where
{
//This class can only accept value type like int ,double, bit ,even included  Struc
    class ValueTypeData<T> where T :struct
    {


    } 

    //This class can only accept which class use comparable 
    class CompareaBale<T> where T : IComparable
    {

    }

    class  ReferenceType<T> where T: class,new()
    {

    }

    class Where
    {
        struct abc
            {
            string name;
            int age;

        }

        public static void Main()
        {
            StringExp();
            Console.ReadKey();
        }
        public static void StringExp()
        {
            //Error :-- must be non ref --- non nullable
            //ValueTypeData<string> valObj = new ValueTypeData<string>();

            
            ValueTypeData<abc> valStruc = new ValueTypeData<abc>();
        }
        public static void StrucExp()
        {
            //Error :-- must be non ref --- non nullable
            //ValueTypeData<string> valObj = new ValueTypeData<string>();

            ValueTypeData<abc> valStruc = new ValueTypeData<abc>();
        }

        public static void IntBit()
        {
            //Error :-- must be non ref --- non nullable
            //ValueTypeData<string> valObj = new ValueTypeData<string>();

            ValueTypeData<abc> valStruc = new ValueTypeData<abc>();
        }

    }



}
