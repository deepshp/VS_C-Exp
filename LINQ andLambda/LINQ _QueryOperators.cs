using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_andLambda
{
    class LINQ_QueryOperators
    {
        public static void Filtering_Operators_Where()
        {
            string[] words = { "humpty", "dumpty", "set", "on", "a", "wall" };

            IEnumerable<string> query = from word in words
                                        where word.Length == 3
                                        select word;
            foreach (string str in query)
                Console.WriteLine(str);

        }
        public static void JoinOperators()
        {
            List<DependentClass.DepartmentClass> departments = new List<DependentClass.DepartmentClass>();
            departments.Add(new DependentClass.DepartmentClass { DepartmentId = 1, Name = "Account" });
            departments.Add(new DependentClass.DepartmentClass { DepartmentId = 2, Name = "Sales" });
            departments.Add(new DependentClass.DepartmentClass { DepartmentId = 3, Name = "Marketing" });

            List<DependentClass.EmployeeClass> employees = new List<DependentClass.EmployeeClass>();
            employees.Add(new DependentClass.EmployeeClass { DepartmentId = 1, EmployeeId = 1, EmployeeName = "William" });
            employees.Add(new DependentClass.EmployeeClass { DepartmentId = 2, EmployeeId = 2, EmployeeName = "Miley" });
            employees.Add(new DependentClass.EmployeeClass { DepartmentId = 1, EmployeeId = 3, EmployeeName = "Benjamin" });



            var list = from d in departments
                       join e in employees on d.DepartmentId equals e.DepartmentId
                       select new
                       {
                           EmployeesName = e.EmployeeName,
                           DepartmentName = d.Name
                       };

            foreach(var ob in list)
            {
                Console.WriteLine(ob.DepartmentName +"  "+ob.EmployeesName);
            }
        }

        public static void ProjectionOperationsSelect()
        {
            List<String> lstOfString = new List<string>() { "preet","jass","deep"};
            // var words = from list in lstOfString select list; // Den vil tilbage alle ord
            var words = from list in lstOfString select list.Substring(1,2);
            foreach(var  word in words)
            {
                Console.WriteLine(word);

            }

        }
        public static void ProjectionOperationsSelect2()
        {
            List<String> lstOfString = new List<string>()  { "an apple a day", "the quick brown fox" };

            // var words = from list in lstOfString select list; // Den vil tilbage alle ord
            var words = from list in lstOfString
                        from word in list.Split(' ') 
                        select word;
            foreach (var word in words)
            {
                Console.WriteLine(word);

            }

        }

        public static void SortingOperatorsOrderBy()
        {
            /*
             * The operator sort values in an ascending order
             */
            Console.WriteLine("Sorting ");

            int[] intArr = {9,5,6,7,4,1,4,6 };
            var posNum = from n in intArr orderby n select n;
            IEnumerable<int> tt =  from n in intArr orderby n select n;

            foreach(int val in tt)
            {
                Console.WriteLine(val);
            }




        }
        //OrderByDescending
        public static void SortingOperatorsOrderByDecending()
        {
            /*
             * The operator sort values in an ascending order
             */
            Console.WriteLine("Sorting--OrderByDescending ");

            int[] intArr = { 9, 5, 6, 7, 4, 1, 4, 6 };
            var posNum = from n in intArr orderby n select n;
            IEnumerable<int> tt = from n in intArr orderby n descending select n;

            foreach (int val in tt)
            {
                Console.WriteLine(val);
            }




        }
        //ThenBy

        public static void SortingOperatorsOrdeThenBy()
        {


            Console.WriteLine("Sorting------ThenBy ");
            // Array  of Employee Class
            DependentClass.EmployeeClass[] empObject = new DependentClass.EmployeeClass[5];
                empObject[0] = new DependentClass.EmployeeClass { DepartmentId = 1, EmployeeId = 1, EmployeeName = "William" };

            //Create List 
                    List<DependentClass.EmployeeClass> listEmpObjects = new List<DependentClass.EmployeeClass>();
                    listEmpObjects.Add(new DependentClass.EmployeeClass { DepartmentId=1,EmployeeId=1102,EmployeeName="jass" });

                    listEmpObjects.Add(new DependentClass.EmployeeClass { DepartmentId = 1, EmployeeId = 1102, EmployeeName = "jass" });

                    listEmpObjects.Add(new DependentClass.EmployeeClass { DepartmentId = 5, EmployeeId = 1105, EmployeeName = "jass" });

                    listEmpObjects.Add(new DependentClass.EmployeeClass { DepartmentId = 6, EmployeeId = 1108, EmployeeName = "jass" });

                    listEmpObjects.Add(new DependentClass.EmployeeClass { DepartmentId = 7, EmployeeId = 1101, EmployeeName = "jass" });

                    listEmpObjects.Add(new DependentClass.EmployeeClass { DepartmentId = 3, EmployeeId = 1104, EmployeeName = "jass" });

            // linQ Exprestion
            var outPut = from empObj in listEmpObjects orderby empObj.DepartmentId ,empObj.EmployeeId select empObj;

            IEnumerable<DependentClass.EmployeeClass> outPutE = from empObj in listEmpObjects  select empObj;

            

            foreach (DependentClass.EmployeeClass obj in outPut)
            {

                Console.WriteLine(obj.DepartmentId +"   " +obj.EmployeeId);

            }

        }
        //ThenByDescending
        //Reverse
        public static void GroupBy()
        {

            List<int> lst = new List<int> { 1,2,3,4,5,6,7,8 };

            var outPutData = from num1 in lst group num1 by num1%2==0 ;


            var dat=from number in lst
            group number by number % 2;

            foreach (var group in outPutData)
            {
                var key = group.Key;
                var groupElements = group.ToArray();
                foreach(var gItems in groupElements)
                {
                    Console.WriteLine(key +"--  "+ gItems );

                }
             
                Console.WriteLine("-----next Group-----");

            }

        }

        public static void CastExp()
        {

                DependentClass.Plant[] plants = new DependentClass.Plant[] {new DependentClass.CarnivorousPlant { Name = "Venus Fly Trap", TrapType = "Snap Trap" },
                                      new DependentClass.CarnivorousPlant { Name = "Pitcher Plant", TrapType = "Pitfall Trap" },
                                      new DependentClass.CarnivorousPlant { Name = "Sundew", TrapType = "Flypaper Trap" },
                                      new DependentClass.CarnivorousPlant { Name = "Waterwheel Plant", TrapType = "Snap Trap" }};

                var query = from DependentClass.CarnivorousPlant cPlant in plants
                            where cPlant.TrapType == "Snap Trap"
                            select cPlant;

                foreach (var e in query)
                {
                    Console.WriteLine("Name = {0} , Trap Type = {1}",
                                      e.Name, e.TrapType);
                }

                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
            }
        }
       }


        public static void Temp()
        {


        }
    }
}
