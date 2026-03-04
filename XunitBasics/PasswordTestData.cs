using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace XunitBasics
{
	public class PasswordTestData : IEnumerable<object[]>
	{
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

		public IEnumerator<object[]> GetEnumerator()
		{
			yield return new object[] { "password123", true };
			yield return new object[] { "short", false };
			yield return new object[] { "mypassword", true };
			yield return new object[] { "", false };
		}
	}
}
