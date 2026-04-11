using ConsoleApplications;

namespace XunitBasics
{
	public class AnimalTests
	{
		[Fact]
		public void TestAllAnimalMethods()
		{
			// Arrange
			var animal = new Animal("Tiger");

			// Act & Assert
			// Test constructor and Greet method
			animal.Greet();
			Assert.Equal("Tiger", animal.name);

			// Test Eat method
			animal.Eat("meat");
			animal.Eat("fish");
			Assert.Equal(2, animal.gut.Count);
			Assert.Contains("meat", animal.gut);
			Assert.Contains("fish", animal.gut);

			// Test Excrete method
			animal.Excrete();
			Assert.Equal(1, animal.gut.Count);
			Assert.DoesNotContain("meat", animal.gut);

			// Test ToString method
			string result = animal.ToString();
			Assert.Equal("Animal:Tiger", result);
		}
	}
}
