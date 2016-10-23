using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace XMLProcessing
{
    class Program
    {
        static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../../music-cataloque.xml");

            var cataloque = doc.DocumentElement;

            var dOMauthors = ParseAuthorsDOM(cataloque);
            Console.WriteLine("Auhtors Dom");
            PrintAuthors(dOMauthors);
            Console.WriteLine();


            var xPathAuthors = ParseAuthorsXPath(cataloque);
            Console.WriteLine("Auhtors XPath");
            PrintAuthors(xPathAuthors);
            Console.WriteLine();

            var nodesToRemove = cataloque.SelectNodes("album[price > '20']");
            foreach (XmlNode nodeToRemove in nodesToRemove)
            {
                cataloque.RemoveChild(nodeToRemove);

            }

            Console.WriteLine("Authors after deleting");
            PrintAuthors(ParseAuthorsDOM(cataloque));
            Console.WriteLine();

            var titles = new List<string>();

            var reader = XmlReader.Create("../../../music-cataloque.xml");

            while (reader.Read())
            {
                if(reader.NodeType == XmlNodeType.Element)
                {
                    if(reader.Name == "song")
                    {
                        titles.Add(reader.GetAttribute("name"));
                    }
                }
            }
            Console.WriteLine("All titles");
            Console.WriteLine(string.Join("\n", titles));
            Console.WriteLine();


        }

        private static void PrintAuthors(IEnumerable<KeyValuePair<string, int>> authors)
        {
            foreach (var item in authors)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} albums");
            }
        }

        private static IEnumerable<KeyValuePair<string, int>> ParseAuthorsXPath(XmlElement cataloque)
        {
            var authors = new Dictionary<string, int>();

            var authorsNodes = cataloque.SelectNodes("album/artist[not(text() = preceding::album/artist/text())]/text()");

            foreach (XmlNode authorNode in authorsNodes)
            {
                var authorName = authorNode.Value;

                var authorAlbums = cataloque.SelectNodes($"album[artist/text() = '{authorName}']");

                authors.Add(authorName, authorAlbums.Count);

                
            }

            return authors;
        }
        
        private static IEnumerable<KeyValuePair<string, int>> ParseAuthorsDOM(XmlElement cataloque)
        {
            var authors = new Dictionary<string, int>();

            foreach (XmlElement album in cataloque)
            {
                var author = album["artist"];

                if (!authors.ContainsKey(author.InnerText))
                {
                    authors.Add(author.InnerText, 1);
                }
                else
                {
                    authors[author.InnerText]++;
                }
            }

            return authors;
        }
    }
}
