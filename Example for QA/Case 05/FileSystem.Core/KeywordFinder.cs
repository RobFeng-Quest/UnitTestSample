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
            TextKeywordFinder textKeywordFinder = new TextKeywordFinder();

            return textKeywordFinder.FindMatchedKeyword(textInFile, aKeyword);
        }
    }
}
