namespace XunitBasics
{
    public class ListsExampleTests
    {
        [Fact]
        public void CreateList_InitializesWithThreeNames()
        {
            // Arrange
            List<string> names = ["somesh", "rakesh", "rajesh"];
            
            // Act & Assert
            Assert.Equal(3, names.Count);
            Assert.Contains("somesh", names);
            Assert.Contains("rakesh", names);
            Assert.Contains("rajesh", names);
        }

        [Fact]
        public void AddNames_IncreasesListCount()
        {
            // Arrange
            List<string> names = ["somesh", "rakesh", "rajesh"];
            
            // Act
            names.Add("Shashank");
            
            // Assert
            Assert.Equal(4, names.Count);
            Assert.Contains("Shashank", names);
        }

        [Fact]
        public void AddMultipleNames_AllNamesAddedSuccessfully()
        {
            // Arrange
            List<string> names = ["somesh", "rakesh", "rajesh"];
            
            // Act
            names.Add("Shashank");
            names.Add("Venkatesh");
            names.Add("Ashok");
            
            // Assert
            Assert.Equal(6, names.Count);
            Assert.Contains("Shashank", names);
            Assert.Contains("Venkatesh", names);
            Assert.Contains("Ashok", names);
        }

        [Fact]
        public void Sort_ArrangesNamesAlphabetically()
        {
            // Arrange
            List<string> names = ["somesh", "rakesh", "rajesh"];
            
            // Act
            names.Sort();
            
            // Assert
            Assert.Equal(["rajesh", "rakesh", "somesh"], names);
        }

        [Fact]
        public void SortAfterAddition_ArrangesAllNamesAlphabetically()
        {
            // Arrange
            List<string> names = ["somesh", "rakesh", "rajesh"];
            names.Add("Shashank");
            names.Add("Venkatesh");
            names.Add("Ashok");
            
            // Act
            names.Sort();
            
            // Assert
            List<string> expected = ["Ashok", "Shashank", "Venkatesh", "rajesh", "rakesh", "somesh"];
            Assert.Equal(expected, names);
        }

        [Fact]
        public void ListCount_ReturnsCorrectNumberOfItems()
        {
            // Arrange
            List<string> names = ["somesh", "rakesh", "rajesh"];
            
            // Act
            int count = names.Count;
            
            // Assert
            Assert.Equal(3, count);
        }

        [Fact]
        public void ListContains_ReturnsTrueForExistingName()
        {
            // Arrange
            List<string> names = ["somesh", "rakesh", "rajesh"];
            
            // Act & Assert
            Assert.True(names.Contains("somesh"));
        }

        [Fact]
        public void ListContains_ReturnsFalseForNonExistingName()
        {
            // Arrange
            List<string> names = ["somesh", "rakesh", "rajesh"];
            
            // Act & Assert
            Assert.False(names.Contains("nonexistent"));
        }

        [Fact]
        public void ListIndex_ReturnsCorrectName()
        {
            // Arrange
            List<string> names = ["somesh", "rakesh", "rajesh"];
            
            // Act
            string firstName = names[0];
            string secondName = names[1];
            string thirdName = names[2];
            
            // Assert
            Assert.Equal("somesh", firstName);
            Assert.Equal("rakesh", secondName);
            Assert.Equal("rajesh", thirdName);
        }

        [Fact]
        public void EmptyList_HasZeroCount()
        {
            // Arrange
            List<string> names = [];
            
            // Act & Assert
            Assert.Equal(0, names.Count);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        public void AddNames_IncreaseCountByOne(int initialCount)
        {
            // Arrange
            List<string> names = [];
            for (int i = 0; i < initialCount; i++)
            {
                names.Add($"name{i}");
            }
            int beforeAdd = names.Count;
            
            // Act
            names.Add("newname");
            
            // Assert
            Assert.Equal(beforeAdd + 1, names.Count);
        }

        [Fact]
        public void CaseInsensitiveComparison_ListContainsIsCaseSensitive()
        {
            // Arrange
            List<string> names = ["somesh", "rakesh", "rajesh"];
            
            // Act & Assert
            Assert.False(names.Contains("Somesh")); // List.Contains is case-sensitive
            Assert.True(names.Contains("somesh"));
        }
    }
}
