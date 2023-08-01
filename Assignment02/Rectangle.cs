using System;

namespace Assignment02
{
    public class Rectangle
    {
        private int length;
        private int width;

        // Default constructor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        // Non-default constructor
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetCurrentLength()
        {
            return length;
        }

        public int SetNewLength(int length)
        {
            this.length = length;
            return this.length;
        }

        public int GetCurrentWidth()
        {
            return width;
        }

        public int SetNewWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        public int GetArea()
        {
            return length * width;
        }
    }

}
