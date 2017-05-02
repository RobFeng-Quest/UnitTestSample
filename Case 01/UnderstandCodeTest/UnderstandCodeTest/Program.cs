using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandCodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SimpleParserTests.ParseAndSum_ReturnZeroWhenEmptyString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();

            try
            {
                SimpleParserTests.ParseAndSum_Return3When3String();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
