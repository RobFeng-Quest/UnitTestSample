using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandCodeTest
{
    public class SimpleParserTests
    {
        public static void ParseAndSum_ReturnZeroWhenEmptyString()
        {
            try
            {
                SimpleParser parser = new SimpleParser();

                int result = parser.ParseAndSum(string.Empty);

                if (result != 1)
                {
                    Console.WriteLine(
                        @"---SimpleParserTests.ParseAndSum_ReturnZeroWhenEmptyString:" + Environment.NewLine
                        + "Parse and sum should have returned 0 on an empty string" + Environment.NewLine
                        + "--------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void ParseAndSum_Return3When3String()
        {
            string testName = MethodBase.GetCurrentMethod().Name;
            try
            {
                SimpleParser parser = new SimpleParser();

                int result = parser.ParseAndSum("4");

                if (result != 3)
                {
                    ShowProblem(testName, "Parse and sum should have returned 3 on an 3 string");
                }
            }
            catch (Exception ex)
            {
                ShowProblem(testName, ex.ToString());
            }
        }

        public static void ShowProblem(string test, string message)
        {
            string msg = string.Format(
                @"---{0}---" + Environment.NewLine
                + "{1}" + Environment.NewLine
                + "--------------------", test, message);
            Console.WriteLine(msg);
        }
    }
}
