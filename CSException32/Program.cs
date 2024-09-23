using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSException32
{
    internal class Program
    {

        class Box
        {
            private int width;
            public int Width
            {
                get { return width; }
                set
                {
                    if (value < 0)
                        throw new Exception("너비는 0보다 큰 수가 되어야 합니다.");
                    width = value;
                }
            }

            private int height;
            public int Height
            {
                get { return height; }
                set
                {
                    if (value < 0)
                        throw new Exception("높이는 0보다 큰 수가 되어야 합니다.");
                    height = value;
                }
            }

            public Box(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public int Area
            {
                get { return width * height;  }                
            }
        }
            static void Main(string[] args)
            {
                Box box = new Box(100, 100);
                box.Width = 200;
                box.Height = 200;
                Console.WriteLine(box.Area);
        }
    }
}
