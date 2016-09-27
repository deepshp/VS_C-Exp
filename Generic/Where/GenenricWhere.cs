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



}
