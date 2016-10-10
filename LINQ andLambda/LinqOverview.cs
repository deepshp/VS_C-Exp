using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_andLambda
{
    class LinqOverview
    {
       public static void GetOnlyParticularWords()
        {
            string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };
            //Get only short words  and shortwors is Ienumrator 
            var slectedWords = from word in words where word.Length <= 5 select word;
            

      //Print each word out
            foreach (var word in slectedWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
        public static void GetOnlyParticularWordsLambda()
        {
            Console.WriteLine("lambda");
            string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };
            //Get only short words  and shortwors is Ienumrator 
            var slectedWords = words.Where(x=>x.Length<=5);


            //Print each word out
            foreach (var word in slectedWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
        public static void PrintData()
        {
            string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };
            //Get only short words
            var shortWords = from word in words
                             where word.Length <= 5
                             select word;

            //Print each word out
            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
        public static void Average()
        {
            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };
            var avarage = (from score in scores select score).Average();
            Console.WriteLine(avarage);

        }
        public static void Sum()
        {
            // Specify the data source.
            int[] scores = new int[] { 1, 5, 1, 3 };
            var avarage = (from score in scores select score).Average();
            Console.WriteLine(avarage);

        }
    }
}
