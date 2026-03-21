namespace XunitBasics
{
    public class MaxElementSolutionTests
    {
        private readonly ConsoleApplications.MaxElementSolution _solution = new();

        [Fact]
        public void FindMaxElement_WithPositiveNumbers_ReturnsLargestValue()
        {
            // Arrange
            int[] elements = { 121, 32, 45, 300, 41, 50, 100, 200, 11, 75 };
            
            // Act
            int result = _solution._findMaxElement(elements);
            
            // Assert
            Assert.Equal(300, result);
        }

        [Fact]
        public void FindMaxElement_WithSingleElement_ReturnsThatElement()
        {
            // Arrange
            int[] elements = { 42 };
            
            // Act
            int result = _solution._findMaxElement(elements);
            
            // Assert
            Assert.Equal(42, result);
        }

        [Fact]
        public void FindMaxElement_WithTwoElements_ReturnsLargerValue()
        {
            // Arrange
            int[] elements = { 10, 20 };
            
            // Act
            int result = _solution._findMaxElement(elements);
            
            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void FindMaxElement_WithNegativeNumbers_ReturnsLargestValue()
        {
            // Arrange
            int[] elements = { -50, -10, -100, -5, -25 };
            
            // Act
            int result = _solution._findMaxElement(elements);
            
            // Assert
            Assert.Equal(-5, result);
        }

        [Fact]
        public void FindMaxElement_WithMixedPositiveAndNegative_ReturnsLargestValue()
        {
            // Arrange
            int[] elements = { -50, 100, -10, 50, 25, -100 };
            
            // Act
            int result = _solution._findMaxElement(elements);
            
            // Assert
            Assert.Equal(100, result);
        }

        [Fact]
        public void FindMaxElement_WithDuplicateMaxValues_ReturnsMaxValue()
        {
            // Arrange
            int[] elements = { 100, 50, 100, 25, 100 };
            
            // Act
            int result = _solution._findMaxElement(elements);
            
            // Assert
            Assert.Equal(100, result);
        }

        [Fact]
        public void FindMaxElement_WithMaxAtBeginning_ReturnsCorrectValue()
        {
            // Arrange
            int[] elements = { 500, 100, 200, 50 };
            
            // Act
            int result = _solution._findMaxElement(elements);
            
            // Assert
            Assert.Equal(500, result);
        }

        [Fact]
        public void FindMaxElement_WithMaxAtEnd_ReturnsCorrectValue()
        {
            // Arrange
            int[] elements = { 100, 200, 50, 500 };
            
            // Act
            int result = _solution._findMaxElement(elements);
            
            // Assert
            Assert.Equal(500, result);
        }

        [Fact]
        public void FindMaxElement_WithAllSameValues_ReturnsTheValue()
        {
            // Arrange
            int[] elements = { 42, 42, 42, 42, 42 };
            
            // Act
            int result = _solution._findMaxElement(elements);
            
            // Assert
            Assert.Equal(42, result);
        }

        [Fact]
        public void FindMaxElement_WithLargeNumbers_ReturnsLargestValue()
        {
            // Arrange
            int[] elements = { int.MaxValue - 1, int.MaxValue, 1000 };
            
            // Act
            int result = _solution._findMaxElement(elements);
            
            // Assert
            Assert.Equal(int.MaxValue, result);
        }

        [Fact]
        public void FindMaxElement_WithZeroAndNegatives_ReturnsZero()
        {
            // Arrange
            int[] elements = { -100, -50, 0, -10 };
            
            // Act
            int result = _solution._findMaxElement(elements);
            
            // Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, 5)]
        [InlineData(new int[] { 3, 1, 4, 1, 5, 9, 2, 6 }, 9)]
        [InlineData(new int[] { -5, -1, -10, -2 }, -1)]
        public void FindMaxElement_WithVariousArrays_ReturnsCorrectMaximum(int[] elements, int expected)
        {
            // Act
            int result = _solution._findMaxElement(elements);
            
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
