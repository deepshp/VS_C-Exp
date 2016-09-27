using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Interface
{
    interface IGenericInterface<T>
    {

        void AddData(T a, T b);

        T DeleteData(T a, T b);

    }
}
