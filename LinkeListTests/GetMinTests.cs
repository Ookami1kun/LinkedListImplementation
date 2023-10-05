using LinkedListImplementation;

namespace LinkeListTests
{
    public class GetMinTests
    {
        [Theory]
        [InlineData(0, 0, 1, 2, 8, 4)]
        [InlineData(2, int.MaxValue, 2, 999999, 32)]
        [InlineData(int.MinValue, int.MinValue, -1, -15)]
        public void ShouldReturnMinItemFromTheList(int expected, params int[] testArray)
        {
            //Arrange
            var list = new MyLinkedList<int>(testArray);

            //Act
            var result = list.GetMin();

            //Assert
            Assert.Equal(expected, result);
            list.Should().ContainInOrder(testArray);
        }
    }
}
