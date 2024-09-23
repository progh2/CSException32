using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSException32
{
    internal class Program
    {
        class BoxWrongWidthException : Exception
        {
            public BoxWrongWidthException(string message) : base(message)
            {
            }
        }

        class BoxWrongHeightException : Exception
        {
            public BoxWrongHeightException(string message) : base(message)
            {
            }
        }

        class Box
        {
            private int width;
            public int Width
            {
                get { return width; }
                set
                {
                    if (value < 0)
                        throw new BoxWrongWidthException("너비는 0보다 큰 수가 되어야 합니다.");
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
                        throw new BoxWrongHeightException("높이는 0보다 큰 수가 되어야 합니다.");
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
            try
            {
                Box box = new Box(100, 100);
                box.Width = 200;
                box.Height = 200;
                Console.WriteLine(box.Area);

                Box wrongBox = new Box(10, 10);
                wrongBox.Width = -10;
                //wrongBox.Height = -10;
            }
            catch (BoxWrongWidthException e)
            {
                Console.WriteLine("너비 값 제대로 안넣을래?");
            }
            catch (BoxWrongHeightException e)
            {
                Console.WriteLine("높이 값 제대로 안넣을래?");
            }
            catch (Exception e)
            {
                Console.WriteLine("알 수 없는 에러?");
            }
                
        }
    }
}
