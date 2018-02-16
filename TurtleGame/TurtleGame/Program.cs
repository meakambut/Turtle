using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 200, y = 200;
            Turtle.Speed = 8;
            Turtle.PenUp();

            Random rand = new Random();

            GraphicsWindow.BrushColor = "Yellow";
            var food = Shapes.AddRectangle(10, 10);
            Shapes.Move(food, x, y);
            while (true)
            {
                if (Turtle.X <= x + 10 && Turtle.X >= x && Turtle.Y <= y + 10 && Turtle.Y >= y)
                {
                    x = rand.Next(0, GraphicsWindow.Width);
                    y = rand.Next(0, GraphicsWindow.Height);
                    Shapes.Move(food, x, y);
                }
                GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
                Turtle.Move(1);

            }
        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
                Turtle.Angle = 0;
            else if (GraphicsWindow.LastKey == "Right")
                Turtle.Angle = 90;
            else if (GraphicsWindow.LastKey == "Down")
                Turtle.Angle = 180;
            else if (GraphicsWindow.LastKey == "Left")
                Turtle.Angle = -90;
        }
    }
}

