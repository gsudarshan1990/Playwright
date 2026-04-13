using Xunit;
using ConsoleApplications;

namespace XunitBasics
{
    public class CircleTests
    {
        [Theory]
        [InlineData(1, 3.141592653589793)]
        [InlineData(0, 0)]
        [InlineData(2.5, 19.634954084936208)]
        public void GetArea_ReturnsExpectedArea(double radius, double expectedArea)
        {
            var circle = new Circle(radius);
            var area = circle.GetArea();
            Assert.Equal(expectedArea, area, 5);
        }
    }
}
