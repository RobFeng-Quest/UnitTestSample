using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem.UnitTests
{
    [TestFixture]
    public class TextKeywordFinderTests
    {
        [TestCase]
        public void FindMatchedKeyword_Return0WhenNoMatchedKeyword()
        {
            TextKeywordFinder keywordFinder = new TextKeywordFinder();


            string textIncludeKeyword = "Unit Tests!!!";
            int actualResult = keywordFinder.FindMatchedKeyword(textIncludeKeyword, "Hello");

            int expectedResult = 0;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
