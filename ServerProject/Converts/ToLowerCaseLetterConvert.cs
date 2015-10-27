﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerProject.Converts
{
	public class ToLowerCaseLetterConvert : IConvert
	{
		public string Convert(string aContent)
		{
			return aContent.ToUpper();
		}
	}
}