using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;

namespace FileSystem.UnitTests
{
    [TestFixture]
    public class KeywordFinderTests
    {
        public class FileReaderMock : IFileReader
        {
            public string TextInFile { get; set; }

            public string ReadAllText(string aPath)
            {
                return TextInFile;
            }
        }

        [TestCase]
        public void FindMatchedKeyword_Return1MatchedKeyword()
        {
            IFileReader fakeFileReader = new FileReaderMock() { TextInFile = "Hello Mock!!!" };            
            KeywordFinder keywordFinder = new KeywordFinder(fakeFileReader);

            int actualResult = keywordFinder.FindMatchedKeyword(string.Empty, "Hello");

            int expectedResult = 1;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
