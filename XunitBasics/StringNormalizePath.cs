using System;
using System.Collections.Generic;
using System.Text;

namespace AIAssistedDevelopment
{
	public class StringNormalizePath
	{
		public static string NormalizePath(string path)
		{
			path = path.Replace('\\', '/');
			return path;
		}

		//add a function to get the filename from the absolute path or relative path - Copilot

		public static string GetFileName(string path)
		{
			// Normalize the path first to handle both Windows and Unix separators
			string normalizedPath = NormalizePath(path);

			// Get the last segment after the final separator
			int lastSeparatorIndex = normalizedPath.LastIndexOf('/');

			if (lastSeparatorIndex == -1)
			{
				// No separator found, the entire string is the filename
				return normalizedPath;
			}

			// Return everything after the last separator
			return normalizedPath.Substring(lastSeparatorIndex + 1);
		}
	}
}
