using LinkedListImplementation;

namespace LinkeListTests
{
    public class ContainsTests
    {
        [Theory]
        [InlineData(0, 1, 2, 3, 4, 5)]
        [InlineData(int.MaxValue, 0, int.MinValue)]
        [InlineData(100000, -213123, 3333, 0)]
        public void ShouldHasItem(params int[] testArray)
        {
            //Arrange
            var list = new MyLinkedList<int>(testArray);

            //Act
            bool result = list.Contains(0);

            //Assert
            result.Should().BeTrue();
        }

        public void ShouldNotHasItem(params int[] testArray)
        {
            //Arrange
            var list = new MyLinkedList<int>(testArray);

            //Act
            bool result = list.Contains(28);

            //Assert
            result.Should().BeFalse();
        }
    }
}
