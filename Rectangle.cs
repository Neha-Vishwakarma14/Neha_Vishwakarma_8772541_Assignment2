using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neha_Vishwakarma_8772541_Assignment2
{
    public class Rectangle
    {
        private int length;
        private int width;

        //Default constructor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        public Rectangle(int a, int b)
        {
            length = a;
            width = b;
        }

        public int GetLength()
        {
            return length;
        }
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int width)
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

