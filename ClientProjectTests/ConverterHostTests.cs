using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientProject;
using NUnit.Framework;

namespace ClientProjectTests
{
	[TestFixture]
	public class ConverterHostTests
	{
		[Test]
		public void ConvertToLower()
		{
			// arrange
			string convertContent = "ABC";
			string expected = "abc";
			ConverterHost converterHost = new ConverterHost();

			// action
			string actual = converterHost.ToLower(convertContent);

			// assert
			Assert.AreEqual(expected, actual);
		}

		[TestCase("ABC", "ABC")]
		[TestCase("A_c", "A_C")]
		[TestCase("123", "123")]
		public void ConvertTheContentToUpper(string convertContent, string expected)
		{
			// arrange
			ConverterHost converterHost = new ConverterHost();

			// action
			string actual = converterHost.ToUpper(convertContent);

			// assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		private static string[][] ToLowerCases =
		{
			new string[] { "123", "123" },
			new string[] { "aBc", "abc" }, 
			new string[] { "A_bcdefg", "a_bcdefg" }
		};

		[Test, TestCaseSource("ToLowerCases")]
		public void ConvertTheContentToLower(string convertContent, string expected)
		{
			// arrange
			ConverterHost converterHost = new ConverterHost();

			// action
			string actual = converterHost.ToLower(convertContent);

			// assert
			Assert.That(actual, Is.EqualTo(expected));
		}

	}
}
