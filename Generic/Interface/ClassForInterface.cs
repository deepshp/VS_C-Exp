using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Interface
{
    class ClassForInterface<T> : IGenericInterface<T>
    {
        public void AddData(T a, T b)
        {
            Console.WriteLine("a="+a +" B="+b); 
        }

        public T DeleteData(T a, T b)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void DeleteData()
        {
            Console.WriteLine();
        }
    }
}
