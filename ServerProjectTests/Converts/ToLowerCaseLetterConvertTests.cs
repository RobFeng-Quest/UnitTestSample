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

		private string convertContent = null;
		private string expected = null;
		private string actual = null;

		[Test]
		public void TestCaseConvertToLower()
		{
			// Given a upper string "ABC"
			AUpperString();

			// When calling the convert  
			CallingTheConvert();

			// Then it should be return a lower string
			ItShouldBeReturnALowerString();
		}

		private void AUpperString()
		{
			convertContent = "ABC";
			expected = "abc";
		}

		private void CallingTheConvert()
		{
			ToLowerCaseLetterConvert converterHost = new ToLowerCaseLetterConvert();
			actual = converterHost.Convert(convertContent);
		}

		private void ItShouldBeReturnALowerString()
		{
			Assert.AreEqual(expected, actual);
		}
	}
}
