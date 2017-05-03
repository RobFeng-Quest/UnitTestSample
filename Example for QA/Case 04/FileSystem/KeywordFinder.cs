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
        private IFileReader FFileReader = null;

        public KeywordFinder(IFileReader aFileReader)
        {
            FFileReader = aFileReader;
        }

        public int FindMatchedKeyword(string aFilePath, string aKeyword)
        {
            string textInFile = FFileReader.ReadAllText(aFilePath);
            TextKeywordFinder textKeywordFinder = new TextKeywordFinder();

            return textKeywordFinder.FindMatchedKeyword(textInFile, aKeyword);
        }
    }
}
