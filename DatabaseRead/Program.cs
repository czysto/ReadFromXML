using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace DatabaseRead
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlReader reader = XmlReader.Create("C:\\Temp\\KontaktOsoba_202009201307.xml");

            reader.ReadToFollowing("KontaktOsoba");

            do
            {
                reader.ReadToFollowing("Nazwisko");
                Console.WriteLine(reader.ReadElementContentAsString());

                reader.ReadToFollowing("Imie");
                Console.WriteLine(reader.ReadElementContentAsString());

                
                Console.WriteLine("-------------------------");

            } while (reader.ReadToFollowing("KontaktOsoba"));
            Console.ReadKey();

        }
    }
}
