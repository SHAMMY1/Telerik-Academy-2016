using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlPartsersDemo
{
    class Program
    {
        static void Main()
        {

            using (XmlReader reader = XmlReader.Create("../../XMLS/Library.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        Console.WriteLine(reader.Name);
                    }
                    else
                    {
                        Console.WriteLine($"Element type -> {reader.NodeType} ElementHTML -> {reader.Prefix}");
                    }
                }
            }
        }
    }
}
