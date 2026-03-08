namespace XunitBasics
{
	public class Class1Tests
	{
		[Fact]
		public void SentenceWords_Contains_AllExpectedWords()
		{
			// Arrange
			string[] SentenceWords = {
									"the",
									"quick",
									"brown",
									"fox",
									"jumps"
								};

			// Act & Assert
			Assert.Equal(5, SentenceWords.Length);
			Assert.Contains("the", SentenceWords);
			Assert.Contains("quick", SentenceWords);
			Assert.Contains("brown", SentenceWords);
			Assert.Contains("fox", SentenceWords);
			Assert.Contains("jumps", SentenceWords);
		}

		[Fact]
		public void SentenceWords_OrderByAlphabetically_ReturnsCorrectOrder()
		{
			// Arrange
			string[] SentenceWords = {
									"the",
									"quick",
									"brown",
									"fox",
									"jumps"
								};

			// Act
			IEnumerable<string> query = from word in SentenceWords
										orderby word
										select word;

			string[] sortedArray = query.ToArray();

			// Assert
			Assert.Equal(new[] { "brown", "fox", "jumps", "quick", "the" }, sortedArray);
		}

		[Fact]
		public void SortedWords_FirstElement_IsBrown()
		{
			// Arrange
			string[] SentenceWords = {
									"the",
									"quick",
									"brown",
									"fox",
									"jumps"
								};

			// Act
			IEnumerable<string> query = from word in SentenceWords
										orderby word
										select word;

			string firstWord = query.First();

			// Assert
			Assert.Equal("brown", firstWord);
		}

		[Fact]
		public void SortedWords_LastElement_IsThe()
		{
			// Arrange
			string[] SentenceWords = {
									"the",
									"quick",
									"brown",
									"fox",
									"jumps"
								};

			// Act
			IEnumerable<string> query = from word in SentenceWords
										orderby word
										select word;

			string lastWord = query.Last();

			// Assert
			Assert.Equal("the", lastWord);
		}

		[Fact]
		public void SortedWords_Count_EqualsOriginalCount()
		{
			// Arrange
			string[] SentenceWords = {
									"the",
									"quick",
									"brown",
									"fox",
									"jumps"
								};

			// Act
			IEnumerable<string> query = from word in SentenceWords
										orderby word
										select word;

			int count = query.Count();

			// Assert
			Assert.Equal(SentenceWords.Length, count);
		}

		[Fact]
		public void SortedWords_PreservesAllOriginalWords()
		{
			// Arrange
			string[] SentenceWords = {
									"the",
									"quick",
									"brown",
									"fox",
									"jumps"
								};

			// Act
			IEnumerable<string> query = from word in SentenceWords
										orderby word
										select word;

			// Assert
			foreach (var word in SentenceWords)
			{
				Assert.Contains(word, query);
			}
		}

		[Fact]
		public void SortedWords_IsInAscendingOrder()
		{
			// Arrange
			string[] SentenceWords = {
									"the",
									"quick",
									"brown",
									"fox",
									"jumps"
								};

			// Act
			IEnumerable<string> query = from word in SentenceWords
										orderby word
										select word;

			string[] sortedArray = query.ToArray();

			// Assert
			for (int i = 0; i < sortedArray.Length - 1; i++)
			{
				Assert.True(
					string.Compare(sortedArray[i], sortedArray[i + 1]) <= 0,
					$"Words are not in ascending order: {sortedArray[i]} should come before {sortedArray[i + 1]}"
				);
			}
		}

		[Fact]
		public void EmptyArray_OrderBy_ReturnsEmpty()
		{
			// Arrange
			string[] SentenceWords = { };

			// Act
			IEnumerable<string> query = from word in SentenceWords
										orderby word
										select word;

			// Assert
			Assert.Empty(query);
		}

		[Fact]
		public void SingleWord_OrderBy_ReturnsSingleWord()
		{
			// Arrange
			string[] SentenceWords = { "hello" };

			// Act
			IEnumerable<string> query = from word in SentenceWords
										orderby word
										select word;

			// Assert
			Assert.Single(query);
			Assert.Equal("hello", query.First());
		}

		[Theory]
		[InlineData(new string[] { "zebra", "apple", "mango" }, new string[] { "apple", "mango", "zebra" })]
		[InlineData(new string[] { "c", "a", "b" }, new string[] { "a", "b", "c" })]
		[InlineData(new string[] { "dog", "cat", "bird", "ant" }, new string[] { "ant", "bird", "cat", "dog" })]
		public void OrderBy_WithVariousInputs_ReturnsSortedResults(string[] input, string[] expected)
		{
			// Act
			IEnumerable<string> query = from word in input
										orderby word
										select word;

			// Assert
			Assert.Equal(expected, query.ToArray());
		}
	}
}