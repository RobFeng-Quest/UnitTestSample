using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;

namespace FileSystem.IntegrationTests
{
    [TestFixture]
    public class KeywordFinderTests
    {
        [TestCase]
        public void FindMatchedKeyword_Return3MatchedKeyword()
        {
            string textInFile = "Hello Integration Tests!!! Hello hello";
            string filePath = @"C:\temp\FileForFindMatchedKeywordIntegrationTests.txt";
            File.WriteAllText(filePath, textInFile);

            KeywordFinder keywordFinder = new KeywordFinder();
            int actualResult = keywordFinder.FindMatchedKeyword(filePath, "Hello");

            int expectedResult = 3;
            Assert.AreEqual(expectedResult, actualResult);

            //File.Delete(filePath);
        }
    }
}
