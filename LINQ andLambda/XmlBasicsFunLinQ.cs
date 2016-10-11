using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace LINQ_andLambda
{
    class XmlBasicsFunLinQ
    {
        private static string GetXml()
        {
            string myXML = @"<Departments>
                       <Department>Account</Department>
                       <Department>Sales</Department>
                       <Department>Pre-Sales</Department>
                       <Department>Marketing</Department>
                       </Departments>";
            return myXML;

        }

        public static void ReadXMLFileUsingLINQ()
        {
            Console.WriteLine("------  Xml Experiments --------");
          
            XDocument xDoc = new XDocument();

            xDoc = XDocument.Parse(GetXml());
            // XElement elements = xDoc.Element("Departments").Descendants();
            /*
              .Descendants() function convert it Enumaration
              */
            var elements = xDoc.Element("Departments").Descendants();
            //it is return Elements f.exp <Department>Account</Department>
            foreach (var element in elements)
                Console.WriteLine(element); // it  will return  <Department>Account</Department> not value
             //it is return Elements Vlaue f.ex Account
            foreach (var element in elements)
                Console.WriteLine(element.Value); // it  will return ONLY value





        }
        public static void AddNewNode()
        {
            /*
                her vi skal  tilføje en ny node i eksistede xml
             */

            XDocument xDoc = new XDocument();

            xDoc = XDocument.Parse(GetXml());// få en xml String
            // Elenments er Enumaration ,arbejder med Descendants
            

            xDoc.Element("Departments").Add(new XElement("NewDep","valueNewDe"));

            var elements = xDoc.Element("Department").Descendants();

            foreach (XElement elemnt in elements)
                Console.WriteLine(elemnt);


        }
    }
}
