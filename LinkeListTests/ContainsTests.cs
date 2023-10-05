using LinkedListImplementation;

namespace LinkeListTests
{
    public class ContainsTests
    {
        [Theory]
        [InlineData(true, 4, 0, 1, 2, 3, 4, 5)]
        [InlineData(true, int.MaxValue, int.MaxValue, 0, int.MinValue)]
        [InlineData(true, -213123, 100000, -213123, 3333, 0)]
        [InlineData(false, -2222, 0, 222, 213, 3, int.MaxValue)]
        [InlineData(false, -999999, 0, 222, -3020213, 3, int.MinValue)]

        public void ShouldHasItem(bool expected, int containInt, params int[] testArray)
        {
            //Arrange
            var list = new MyLinkedList<int>(testArray);

            //Act
            
            bool result = list.Contains(containInt);

            //Assert
            result.Should().Be(expected);
            list.Should().ContainInOrder(testArray);
        }
    }
}
