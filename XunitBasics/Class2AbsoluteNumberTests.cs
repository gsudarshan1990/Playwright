using AIAssistedDevelopment;

namespace XunitBasics
{


	public class Class2AbsouluteNumberTests
	{
		private readonly Class2AbsouluteNumber _absoluteNumber = new Class2AbsouluteNumber();

		[Fact]
		public void AbsoluteNumber_WithNegativeNumber_ReturnsPositive()
		{
			// Arrange
			int number = -5;

			// Act
			int result = _absoluteNumber.AbsoluteNumber(number);

			// Assert
			Assert.Equal(5, result);
		}

		[Fact]
		public void AbsoluteNumber_WithPositiveNumber_ReturnsSameNumber()
		{
			// Arrange
			int number = 5;

			// Act
			int result = _absoluteNumber.AbsoluteNumber(number);

			// Assert
			Assert.Equal(5, result);
		}

		[Fact]
		public void AbsoluteNumber_WithZero_ReturnsZero()
		{
			// Arrange
			int number = 0;

			// Act
			int result = _absoluteNumber.AbsoluteNumber(number);

			// Assert
			Assert.Equal(0, result);
		}

		[Fact]
		public void AbsoluteNumber_WithLargeNegativeNumber_ReturnsPositive()
		{
			// Arrange
			int number = -2147483647;

			// Act
			int result = _absoluteNumber.AbsoluteNumber(number);

			// Assert
			Assert.Equal(2147483647, result);
		}

		[Fact]
		public void AbsoluteNumber_WithLargePositiveNumber_ReturnsSameNumber()
		{
			// Arrange
			int number = 2147483647;

			// Act
			int result = _absoluteNumber.AbsoluteNumber(number);

			// Assert
			Assert.Equal(2147483647, result);
		}

		[Fact]
		public void AbsoluteNumber_WithNegativeOne_ReturnsOne()
		{
			// Arrange
			int number = -1;

			// Act
			int result = _absoluteNumber.AbsoluteNumber(number);

			// Assert
			Assert.Equal(1, result);
		}

		[Fact]
		public void AbsoluteNumber_WithPositiveOne_ReturnsOne()
		{
			// Arrange
			int number = 1;

			// Act
			int result = _absoluteNumber.AbsoluteNumber(number);

			// Assert
			Assert.Equal(1, result);
		}

		[Theory]
		[InlineData(-10, 10)]
		[InlineData(-100, 100)]
		[InlineData(-999, 999)]
		[InlineData(10, 10)]
		[InlineData(100, 100)]
		[InlineData(999, 999)]
		[InlineData(0, 0)]
		[InlineData(-42, 42)]
		[InlineData(42, 42)]
		public void AbsoluteNumber_WithVariousInputs_ReturnsAbsoluteValue(int input, int expected)
		{
			// Act
			int result = _absoluteNumber.AbsoluteNumber(input);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void AbsoluteNumber_ResultIsAlwaysNonNegative()
		{
			// Arrange
			int[] testNumbers = { -50, -1, 0, 1, 50 };

			// Act & Assert
			foreach (var number in testNumbers)
			{
				int result = _absoluteNumber.AbsoluteNumber(number);
				Assert.True(result >= 0, $"Result {result} for input {number} should be non-negative");
			}
		}

		[Theory]
		[InlineData(-5)]
		[InlineData(-100)]
		[InlineData(-1)]
		public void AbsoluteNumber_WithNegativeNumbers_ReturnsPositiveValue(int negativeNumber)
		{
			// Act
			int result = _absoluteNumber.AbsoluteNumber(negativeNumber);

			// Assert
			Assert.True(result > 0, $"Result should be positive for negative input {negativeNumber}");
		}

		[Theory]
		[InlineData(5)]
		[InlineData(100)]
		[InlineData(1)]
		public void AbsoluteNumber_WithPositiveNumbers_ReturnsPositiveValue(int positiveNumber)
		{
			// Act
			int result = _absoluteNumber.AbsoluteNumber(positiveNumber);

			// Assert
			Assert.True(result > 0, $"Result should be positive for positive input {positiveNumber}");
		}
	}
}