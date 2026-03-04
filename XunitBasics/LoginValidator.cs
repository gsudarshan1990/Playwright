using System;
using System.Collections.Generic;
using System.Text;

namespace XunitBasics
{
	public class LoginValidator
	{
		public bool passwordCheck(string inputPassword)
		{
			if (string.IsNullOrEmpty(inputPassword))
				return false;

			return inputPassword.Length >= 8;
		}
	}
}
