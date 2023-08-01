using Assignment02;
using NUnit.Framework;

namespace RectangleTests
{

    public class RectangleTest
    {
        [Test]
        public void GetCurrentLength_InitialLength_ReturnsOne()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expected = 1;

            // Act
            int actual = rect.GetCurrentLength();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetCurrentLength_Input5_ReturnsNewLength()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expected = 5;
            rect.SetNewLength(expected);

            // Act
            int actual = rect.GetCurrentLength();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetCurrentLength_InputNegative3_ReturnsNegative()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expected = -3;
            rect.SetNewLength(expected);

            // Act
            int actual = rect.GetCurrentLength();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetNewLength_Input7_ReturnsNewLength()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expected = 7;

            // Act
            int actual = rect.SetNewLength(expected);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetNewLength_Input0_ReturnsZero()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expected = 0;

            // Act
            int actual = rect.SetNewLength(expected);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetNewLength_InputNegative10_ReturnsNegativeLength()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expected = -10;

            // Act
            int actual = rect.SetNewLength(expected);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
