using System;

namespace Rectangle
{
    class Point
    {
        private int X;
        private int Y;

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void Move(int n, int m)
        {
            this.X += n;
            this.Y += m;
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }
    }

    class Rectangle
    {
        private Point LeftTop;
        private Point RightBottom;

        public Rectangle() : this(0, 0)
        {
            Console.WriteLine("Rectangle()");
        }

        public Rectangle(int Left, int Top) : this(Left, Top, Left+100, Top+100)
        {
            Console.WriteLine("Rectangle(int Left, int Top)");
        }

        public Rectangle(int Left, int Top, int Right, int Bottom)
        {
            Console.WriteLine("Rectangle(int Left, int Top. int Top, int Bottom)");
            this.LeftTop = new Point(Left, Top);
            this.RightBottom = new Point(Right, Bottom);
        }

        public void Show()
        {
            Console.WriteLine("left:{0}, top:{1}, width:{2}, height:{3}",
                LeftTop.GetX(), LeftTop.GetY(),
                RightBottom.GetX() - LeftTop.GetX(),
                RightBottom.GetY() - LeftTop.GetY());
        }

        public void Move(int n, int m)
        {
            LeftTop.Move(n, m);
            RightBottom.Move(n, m);
        }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 10, 50, 50);
            rect.Show();

            Rectangle rect2 = new Rectangle();
            rect2.Show();

            Rectangle rect3 = new Rectangle(20, 20);
            rect3.Show();

            Console.ReadLine();
        }
    }

}
