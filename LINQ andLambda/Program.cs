using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_andLambda
{
    class Program
    {


        public static void Main()
        {
            Console.WriteLine("............. Lamabda LinQ");

            LinqExp();
            Console.ReadKey();
        }
        public static void LamdbaExp()
        {
            Console.WriteLine("...Welcome  Lamabda LinQ");
            LambdaExp lambdaObj = new LambdaExp();
            LambdaExp.ArrayExp();
            Console.ReadKey();
        }
        //Exp about Linq

        public static void LinqExp()
        {
            Console.WriteLine("...Welcome   LinqXp");
           

            
            int value = 8;
            switch (value)
            {
                case 1:
                    // LinqOverview.GetOnlyParticularWords();
                    // LinqOverview.GetOnlyParticularWordsLambda();
                    //LinqOverview.PrintData();

                    //LinqOverview.Average();
                     LinqOverview.Sum();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    // join operator basic 
                    // LINQ_QueryOperators.JoinOperators();
                    //LINQ_QueryOperators.ProjectionOperationsSelect();
                    LINQ_QueryOperators.ProjectionOperationsSelect2();
                    break;
                case 5:
                    // Sort Exp 

                    //LINQ_QueryOperators.SortingOperatorsOrderBy();
                    // LINQ_QueryOperators.SortingOperatorsOrderByDecending();

                    LINQ_QueryOperators.SortingOperatorsOrdeThenBy();

                    break;
                case 6:
                    // Group By

                    LINQ_QueryOperators.GroupBy();

                    break;
                case 7:
                    // Sort ojects

                    
                    break;
                case 8:
                    // XML  Experiments
                    XmlBasicsFunLinQ xmlObj = new XmlBasicsFunLinQ();
                    //XmlBasicsFunLinQ.ReadXMLFileUsingLINQ();
                    //XmlBasicsFunLinQ.AddNewNode();
                    //XmlBasicsFunLinQ.AddNewNodeFirst();
                    XmlBasicsFunLinQ.DeletingParticularNode();


                    break;
                default:
                    {
                        System.Console.WriteLine("Not in Range");
                        break;
                    }
            }
               

        }




    }
}
