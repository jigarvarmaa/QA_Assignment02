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

        [Test]
        public void GetCurrentWidth_InitialWidth_ReturnsOne()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expected = 1;

            // Act
            int actual = rect.GetCurrentWidth();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetCurrentWidth_Input27_ReturnsNewWidth()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expected = 27;
            rect.SetNewWidth(expected);

            // Act
            int actual = rect.GetCurrentWidth();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetCurrentWidth_InputNegative45_ReturnsNegative()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expected = -45;
            rect.SetNewWidth(expected);

            // Act
            int actual = rect.GetCurrentWidth();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetNewWidth_Input87_ReturnsNewWidth()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expected = 87;

            // Act
            int actual = rect.SetNewWidth(expected);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetNewWidth_Input0_ReturnsZero()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expected = 0;

            // Act
            int actual = rect.SetNewWidth(expected);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetNewWidth_InputNegative67_ReturnsNegativeWidth()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expected = -67;

            // Act
            int actual = rect.SetNewWidth(expected);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
