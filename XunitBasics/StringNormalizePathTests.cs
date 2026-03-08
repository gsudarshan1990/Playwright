using Xunit;
using AIAssistedDevelopment;

namespace XunitBasics
{
	public class StringNormalizePathTests
	{
		[Fact]
		public void NormalizePath_WithBackslashes_ReplacesWithForwardSlashes()
		{
			// Arrange
			string path = "C:\\Users\\Documents\\file.txt";

			// Act
			string result = StringNormalizePath.NormalizePath(path);

			// Assert
			Assert.Equal("C:/Users/Documents/file.txt", result);
		}

		[Fact]
		public void NormalizePath_WithForwardSlashes_RemainsUnchanged()
		{
			// Arrange
			string path = "/home/user/documents/file.txt";

			// Act
			string result = StringNormalizePath.NormalizePath(path);

			// Assert
			Assert.Equal("/home/user/documents/file.txt", result);
		}

		[Fact]
		public void NormalizePath_WithMixedSlashes_ReplaceAllBackslashes()
		{
			// Arrange
			string path = "C:\\Users/Documents\\file.txt";

			// Act
			string result = StringNormalizePath.NormalizePath(path);

			// Assert
			Assert.Equal("C:/Users/Documents/file.txt", result);
		}

		[Fact]
		public void GetFileName_WithAbsoluteWindowsPath_ReturnsFileName()
		{
			// Arrange
			string path = "C:\\Users\\Documents\\file.txt";

			// Act
			string result = StringNormalizePath.GetFileName(path);

			// Assert
			Assert.Equal("file.txt", result);
		}

		[Fact]
		public void GetFileName_WithAbsoluteUnixPath_ReturnsFileName()
		{
			// Arrange
			string path = "/home/user/documents/file.txt";

			// Act
			string result = StringNormalizePath.GetFileName(path);

			// Assert
			Assert.Equal("file.txt", result);
		}

		[Fact]
		public void GetFileName_WithRelativePath_ReturnsFileName()
		{
			// Arrange
			string path = "folder/subfolder/file.txt";

			// Act
			string result = StringNormalizePath.GetFileName(path);

			// Assert
			Assert.Equal("file.txt", result);
		}

		[Fact]
		public void GetFileName_WithParentDirectoryPath_ReturnsFileName()
		{
			// Arrange
			string path = "../folder/file.txt";

			// Act
			string result = StringNormalizePath.GetFileName(path);

			// Assert
			Assert.Equal("file.txt", result);
		}

		[Fact]
		public void GetFileName_WithFileNameOnly_ReturnsFileName()
		{
			// Arrange
			string path = "file.txt";

			// Act
			string result = StringNormalizePath.GetFileName(path);

			// Assert
			Assert.Equal("file.txt", result);
		}

		[Fact]
		public void GetFileName_WithPathEndingInSeparator_ReturnsEmptyString()
		{
			// Arrange
			string path = "/home/user/documents/";

			// Act
			string result = StringNormalizePath.GetFileName(path);

			// Assert
			Assert.Equal("", result);
		}

		[Fact]
		public void GetFileName_WithMixedSlashes_ReturnsFileName()
		{
			// Arrange
			string path = "C:\\Users/Documents\\file.txt";

			// Act
			string result = StringNormalizePath.GetFileName(path);

			// Assert
			Assert.Equal("file.txt", result);
		}




	}
}