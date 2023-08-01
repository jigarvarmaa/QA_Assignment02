using Assignment02;
using NUnit.Framework;

namespace Assignment02.Tests
{
    public class RectangleTest
    {
        [TestFixture]
        public class RectangleTest1
        {
            [Test]
            public void GetCurrentLength_InitialLength_ReturnsOne()
            {
                //Arrange
                int expected = 1;

                //Act
                int actual = Rectangle.GetCurrentLength();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }

    }
}