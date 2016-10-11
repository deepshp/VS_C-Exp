using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_andLambda
{
    class LambdaExp
    {
        public static void ArrayBasics()
        {
            int[] intArr = {4,6,7,8 };

            List<int> lst = new List<int> { 2,3,5,6};
            lst = intArr.ToList();
            foreach(int val in lst)
            {
                Console.WriteLine(val);
            }
        }
        public static void ArrayExp()
        {
            int[] intArr = { 5, 6, 7, 8 };

            List<int> lst = new List<int> { 5, 3, 5, 6 };
            int index = lst.FindIndex(x=>x%2==0); // it will return first match condition

             
            Console.WriteLine(index);
            // how we can return value  // den vil også tilble første index
            var indexAll = lst.Where(x=>x %2==0);
            

          
            Console.WriteLine(indexAll);
            // return all  value


        }
    }
}
