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

    class ValueTypeExpClass 
    {
        struct abc
         {
            string name;
            int age;
         }

        public static void MainVal()
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
            
            //ValueTypeData<string> valObj = new ValueTypeData<string>();

            ValueTypeData<abc> valStruc = new ValueTypeData<abc>();
        }

        public static void IntBit()
        {
           //

            ValueTypeData<int> valStruc = new ValueTypeData<int>();
            ValueTypeData<bool> valbool = new ValueTypeData<bool>();
            ValueTypeData<Boolean> valboolean = new ValueTypeData<Boolean>();
        }

    }

    class RefTypeExpClass
    {
        public static void MainVal()
        {
             intExp1();
            Console.ReadKey();
        }
        public static void intExp()
        {
            // type must be refrence Type
             //ReferenceType<Int32> refObj = new ReferenceType<Int32>();

           // ReferenceType<Object> refObj = new ReferenceType<object>();


            
        }

        public static void intExp1()
        {
            // type must be refrence Type
            //ReferenceType<Int32> refObj = new ReferenceType<Int32>();

             ReferenceType<Object> refObj = new ReferenceType<object>();



        }
    }



    }
