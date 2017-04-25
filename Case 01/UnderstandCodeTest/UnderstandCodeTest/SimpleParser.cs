using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandCodeTest
{
    public class SimpleParser
    {
        public int ParseAndSum(string aNumbers)
        {
            if (aNumbers.Length == 0)
            {
                return 0;
            }

            if (!aNumbers.Contains(","))
            {
                return int.Parse(aNumbers);
            }
            else
            {
                throw new InvalidOperationException(
                    "I can only handle 0 or 1 number for now!");
            }
        }
    }
}
