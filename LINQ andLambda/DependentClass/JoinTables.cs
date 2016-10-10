using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_andLambda.DependentClass
{
    public class DepartmentClass
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        
    }

   public class EmployeeClass
    {
        public int EmployeeId { set; get; }
        public string EmployeeName { set; get; }
        public int DepartmentId { get; set; }


    }
}
