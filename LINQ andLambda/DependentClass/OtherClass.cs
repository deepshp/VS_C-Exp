using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_andLambda.DependentClass
{
    class Plant
    {
        public string Name { get; set; }
    }

    class CarnivorousPlant : Plant
    {
        public string TrapType { get; set; }
    }
}
