using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ServerProject.Converts;

namespace ServerProjectTests.Converts
{
	[TestFixture]
	public class ToLowerCaseLetterConvertTests
	{
		[Test]
		public void ConvertToLower()
		{
			// arrange
			string convertContent = "ABC";
			string expected = "abc";
			ToLowerCaseLetterConvert converterHost = new ToLowerCaseLetterConvert();

			// action
			string actual = converterHost.Convert(convertContent);

			// assert
			Assert.AreEqual(expected, actual);
		}


		[Test]
		public void TestCaseConvertToLower()
		{
			// Given a upper string "ABC"
			string convertContent = "ABC";
			string expected = "abc";
			ToLowerCaseLetterConvert converterHost = new ToLowerCaseLetterConvert();

			// When calling the convert 
			string actual = converterHost.Convert(convertContent);

			// Then it should be return a lower string
			Assert.AreEqual(expected, actual);
		}
	}
}
