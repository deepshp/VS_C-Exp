using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Basic
{
    class GenericClass<T>
    {

        private T value;
        public GenericClass(T value)
        {

            this.value = value;

        }

        public void PrintName()
        {

            Console.WriteLine("First Genric Class"+value);
        }

        public void Add(T firstParameter, T secondParameter)
        {

          


            Console.WriteLine("ADD Data"+ firstParameter+secondParameter);
        }

    }
}
