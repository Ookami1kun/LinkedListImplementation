using LinkedListImplementation;

namespace LinkeListTests
{
    public class AddStartTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(int.MaxValue)]
        [InlineData(int.MinValue)]
        public void ShouldSuccesfullyAddItemOnTheStartOfEmptyList(int data)
        {
            //Append
            var list = new MyLinkedList<int>();

            //Act
            list.AddStart(data);

            //Assert
            list.Should().StartWith(data);
            list.Should().ContainSingle();
            list.Should().Contain(data);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(int.MaxValue)]
        [InlineData(int.MinValue)]
        public void ShouldSuccesfullyAddTheItemOnTheStartOfTheFilledList(int data)
        {
            //Arrange
            int[] testArray = { 1, 2, 3, 4, 5};
            var list = new MyLinkedList<int>(testArray);

            //Act
            list.AddStart(data);

            //Assert
            list.Should().HaveCount(6);
            list.Should().StartWith(data);
            list.Should().EndWith(list[list.Count - 1]);
            list.Should().Contain(data);
        }
    }
}
