namespace XunitBasics
{
    public class StringTrimmingTests
    {
        [Fact]
        public void TrimStart_RemovesLeadingWhitespace()
        {
            // Arrange
            string greeting = "           Hello World!          ";
            
            // Act
            string result = greeting.TrimStart();
            
            // Assert
            Assert.Equal("Hello World!          ", result);
        }

        [Fact]
        public void TrimEnd_RemovesTrailingWhitespace()
        {
            // Arrange
            string greeting = "           Hello World!          ";
            
            // Act
            string result = greeting.TrimEnd();
            
            // Assert
            Assert.Equal("           Hello World!", result);
        }

        [Fact]
        public void Trim_RemovesLeadingAndTrailingWhitespace()
        {
            // Arrange
            string greeting = "           Hello World!          ";
            
            // Act
            string result = greeting.Trim();
            
            // Assert
            Assert.Equal("Hello World!", result);
        }

        [Fact]
        public void Replace_ReplacesAllOccurrences()
        {
            // Arrange
            string sayHello = "Hello World!";
            
            // Act
            string result = sayHello.Replace("Hello", "Greetings");
            
            // Assert
            Assert.Equal("Greetings World!", result);
        }

        [Fact]
        public void ToLower_ConvertsToLowercase()
        {
            // Arrange
            string sayHello = "Hello World!";
            
            // Act
            string result = sayHello.ToLower();
            
            // Assert
            Assert.Equal("hello world!", result);
        }

        [Fact]
        public void ToUpper_ConvertsToUppercase()
        {
            // Arrange
            string sayHello = "Hello World!";
            
            // Act
            string result = sayHello.ToUpper();
            
            // Assert
            Assert.Equal("HELLO WORLD!", result);
        }

        [Fact]
        public void Contains_FindsSubstring()
        {
            // Arrange
            string songLyrics = "You say goodbye, and I say hello";
            
            // Act
            bool result = songLyrics.Contains("goodbye");
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Contains_ReturnsFalseForMissingSubstring()
        {
            // Arrange
            string songLyrics = "You say goodbye, and I say hello";
            
            // Act
            bool result = songLyrics.Contains("greetings!");
            
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void StartsWith_ReturnsTrueForMatchingStart()
        {
            // Arrange
            string songLyrics = "You say goodbye, and I say hello";
            
            // Act
            bool result = songLyrics.StartsWith("You");
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void StartsWith_ReturnsFalseForNonMatchingStart()
        {
            // Arrange
            string songLyrics = "You say goodbye, and I say hello";
            
            // Act
            bool result = songLyrics.StartsWith("goodbye");
            
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void EndsWith_ReturnsTrueForMatchingEnd()
        {
            // Arrange
            string songLyrics = "You say goodbye, and I say hello";
            
            // Act
            bool result = songLyrics.EndsWith("hello");
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void EndsWith_ReturnsFalseForNonMatchingEnd()
        {
            // Arrange
            string songLyrics = "You say goodbye, and I say hello";
            
            // Act
            bool result = songLyrics.EndsWith("goodbye");
            
            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("Hello World!", "hello world!")]
        [InlineData("UPPERCASE", "uppercase")]
        [InlineData("MixedCase", "mixedcase")]
        public void ToLower_WorksWithVariousInputs(string input, string expected)
        {
            // Act
            string result = input.ToLower();
            
            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("hello world!", "HELLO WORLD!")]
        [InlineData("lowercase", "LOWERCASE")]
        [InlineData("MixedCase", "MIXEDCASE")]
        public void ToUpper_WorksWithVariousInputs(string input, string expected)
        {
            // Act
            string result = input.ToUpper();
            
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
