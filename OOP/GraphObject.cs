using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Specialist.Graph
{
    public abstract class GraphObject //: object
    {
        public string Color;
        public const string DEFAULT_COLOR = "Black";


        public GraphObject()
            : this(DEFAULT_COLOR)
        {
            Console.WriteLine("GraphObject()");
        }

        public GraphObject(string Color)
        {
            Console.WriteLine("GraphObject(string)");
            this.Color = Color;
            scene.Add(this);
        }
        private static List<GraphObject> scene =
            new List<GraphObject>();

        public static void ClearScene()
        {
            scene.Clear();
        }
        public static void DrawScene()
        {
            Console.WriteLine("***********************");
            foreach (GraphObject g in scene)
                g.Draw();
            Console.WriteLine("***********************");
        }

        public static void ScaleScene(double factor)
        {
            foreach (GraphObject g in scene)
            {
                /*if (g is IScaleable)
                {
                    IScaleable s = (IScaleable)g;
                    s.Scale(factor);
                }*/
                IScaleable s = g as IScaleable;
                if (s != null)
                    s.Scale(factor);

            }
        }

        public void DrawBW()
        {
            Console.WriteLine("GraphObject DrawBW");
        }

        public abstract void Draw();
        /*
        public virtual void Draw()
        {
            Console.WriteLine("GraphObject. Color: {0}", Color);
        }*/

    }
}
