using LinkedListImplementation;

namespace LinkeListTests
{
    public class AddTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(int.MaxValue)]
        [InlineData(int.MinValue)]
        public void ShouldSuccesfullyAddOnlyOneItem(int data)
        {
            //Arrange
            var list = new MyLinkedList<int>();

            //Act
            list.Add(data);

            //Assert
            Assert.Equal(1, list.Count);
            Assert.Equal(data, list[0]);
            Assert.Equal(data, list.First());
            list.Should().NotBeNullOrEmpty();
            list.Should().Contain(data);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(int.MaxValue)]
        [InlineData(int.MinValue)]
        public void ShouldSuccesfullyAddItemInFilledList(int data)
        {
            //Arrange
            int[] testArray = { 1, 2, 3, 4, 5 };
            var list = new MyLinkedList<int>(testArray);

            //Act
            list.Add(data);

            //Assert
            Assert.Equal(data, list[list.Count - 1]);
            list.Should().NotBeEmpty();
            list.Should().HaveCount(6);
            list.Should().ContainInOrder(1, 2, 3, 4, 5, data);
            list.Should().Contain(data);
        }
    }


}
