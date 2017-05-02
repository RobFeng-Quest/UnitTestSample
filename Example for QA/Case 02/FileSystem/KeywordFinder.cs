using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    public class KeywordFinder
    {
        public int FindMatchedKeyword(string aFilePath, string aKeyword)
        {
            string textInFile = File.ReadAllText(aFilePath);
            string[] allKeyword = textInFile.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

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
