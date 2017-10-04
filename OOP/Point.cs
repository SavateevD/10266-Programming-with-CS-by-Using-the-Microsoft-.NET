using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Specialist.Graph
{
    public class Point : GraphObject
    {
        public int this[char index]
        {
            get
            {
                switch (index)
                {
                    case 'x': 
                    case 'X': return X;
                    case 'y':
                    case 'Y': return Y;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 'x':
                    case 'X': X = value; break;
                    case 'y':
                    case 'Y': Y = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }

        public int this[int index]
        {
            get 
            {
                switch (index)
                {
                    case 0: return X;
                    case 1: return Y;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0: X = value; break;
                    case 1: Y = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }
        
        private int x;

        /*
        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }*/
        public int Y
        { get; set;  }

        public int X
        {
            get
            {
                return x;
            }
            
            set
            {
                if (value <= 0) throw new ArgumentException("x");
                this.x = value;            
            }
        }



        //public new string Color;
        /*
        public int getX()
        {
            return x;
        }
        public void setX(int x)
        {
            if (x <= 0) throw new ArgumentException("x");
            this.x = x;
        }*/

        public Point(int X, int Y)
            : this(X, Y, DEFAULT_COLOR)
        { }

        public Point(int X, int Y, string Color)
            : base(Color)
        {
            this.x = X;
            this.Y = Y;
            //this.Color = Color;
        }

        public void MoveBy(int dx, int dy)
        {
            x += dx;
            Y += dy;
        }
        public new void DrawBW()
        {
            Console.WriteLine("Point ({0}, {1})",
                x, Y);
        }

        
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Point ({0}, {1}). Color: {2}",
                X, Y, base.Color);
        }

        public override string ToString()
        {
            return string.Format("Point ({0}, {1}). Color: {2}",
                X, Y, Color);
        }

        public static Point operator +(Point p1, Point p2)
        {
                return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public override bool Equals(object obj)
        {
            if (obj is Point)
            {
                Point p2 = (Point)obj;
                return this.X == p2.X && this.Y == p2.Y;
            }
            else
                return false;
        }

        public static bool operator >(Point p1, Point p2)
        {
            return (p1.X * p1.X + p1.Y * p1.Y) > (p2.X * p2.X + p2.Y * p2.Y);
        }
        public static bool operator <(Point p1, Point p2)
        {
            return (p1.X * p1.X + p1.Y * p1.Y) < (p2.X * p2.X + p2.Y * p2.Y);
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return Object.Equals(p1, p2);

        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator double(Point p)
        {
            return Math.Sqrt(p.X * p.X + p.Y * p.Y);
        }

    }
}
