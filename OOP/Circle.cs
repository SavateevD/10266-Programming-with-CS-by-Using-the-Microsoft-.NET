using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Specialist.Graph
{
    public class Circle : GraphObject, IScaleable
    {
        //public int X, Y, Radius;
        public int X { get; set; }
        public int Y { get; set; }
        
        private int radius;
        public int Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                    radius = value;
                else
                    throw new ArgumentException("radius <= 0");
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
                    case 2: return Radius;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }




        public Circle(int X, int Y, int Radius)
        {
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
        }

        
        public override void Draw()
        {
            Console.WriteLine("Circle ({0}, {1}) Radius: {2} Color: {3}",
                X, Y, Radius, Color);
        }

        
        public void Scale(double factor)
        {
            Radius = (int)(Radius * factor);
        }

        void IScaleable.Scale(double factor)
        {
            Radius = (int)(Radius / factor);
        }
    }
}
