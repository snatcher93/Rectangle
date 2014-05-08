﻿using System;

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
        }

        public Rectangle(int Left, int Top) : this(Left, Top, Left+100, Top+100)
        {
        }

        public Rectangle(int Left, int Top, int Right, int Bottom)
        {
            this.LeftTop = new Point(Left, Top);
            this.RightBottom = new Point(Right, Bottom);
        }

        public virtual void Show()
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

    class Square : Rectangle
    {
        private string Color;

        public Square(int Left, int Top, int Width) : base(Left, Top, Left + Width, Top + Width)
        {
        }

        public void ChangeColor(string Color)
        { 
            this.Color = Color; 
        }

        public override void Show() 
        { 
            Console.WriteLine("This is Square"); 
            base.Show();
        }  
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(20, 20, 50, 50);
            rectangle.Show();

            Square square = new Square(20, 20, 50);
            square.Show();

            Console.ReadLine();
        }
    }
}
