using LinkedListImplementation;

namespace LinkeListTests
{
    public class GetMaxTests
    {
        [Theory]
        [InlineData(8, 0, 1, 2, 8, 4)]
        [InlineData(int.MaxValue, int.MaxValue, 2, 999999, 32)]
        [InlineData(-1, int.MinValue, -1, -15)]
        public void ShouldReturnMaxItemFromTheList(int expected, params int[] testArray)
        {
            //Arrange
            var list = new MyLinkedList<int>(testArray);

            //Act
            var result = list.GetMax();

            //Assert
            Assert.Equal(expected, result);
            list.Should().ContainInOrder(testArray);
        }
    }
}
