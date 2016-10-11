using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LINQ_andLambda.XML
{
    class XML_TypeExp
    {
        public static void ReadExternalFiles()
        {
            XmlReader xmlReader = XmlReader.Create("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");

            while (xmlReader.Read())
            {

                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "cube")
                {


                    if (xmlReader.HasAttributes)
                    {
                        Console.WriteLine(xmlReader.GetAttribute("currency") + " " + xmlReader.GetAttribute("rate"));
                    }

                }

            }


        }

        public static void ReadAttribute()
        {
        }

        public static void ReadALL_Attribute()
        {
        }


    }
}

