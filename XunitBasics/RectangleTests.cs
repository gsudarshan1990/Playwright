using Xunit;
using ConsoleApplications;

namespace XunitBasics
{
    public class RectangleTests
    {
        [Theory]
        [InlineData(5, 10, 50)]
        [InlineData(0, 10, 0)]
        [InlineData(7.5, 2, 15)]
        public void GetArea_ReturnsExpectedArea(double length, double breadth, double expectedArea)
        {
            var rectangle = new Rectangle(length, breadth);
            var area = rectangle.GetArea();
            Assert.Equal(expectedArea, area, 5);
        }
    }
}
