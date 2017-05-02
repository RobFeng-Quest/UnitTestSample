using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    public class TextKeywordFinder
    {
        public int FindMatchedKeyword(string aText, string aKeyword)
        {
            string[] allKeyword = aText.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            int matchedNumber = 0;

            foreach (string keyword in allKeyword)
            {
                if (keyword.ToUpper().Contains(aKeyword.ToUpper()) == true)
                {
                    matchedNumber = matchedNumber + 1;
                }
            }

            return matchedNumber;
        }
    }
}
