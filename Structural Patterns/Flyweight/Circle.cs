using System;

namespace Flyweight
{
    public class Circle : Shape
    {
        public string Color { get; set; }
        private int XCor = 10;
        private int YCor = 20;
        private int Radius = 30;

        public void SetColor(string Color)
        {
            this.Color = Color;
        }
        public void Draw()
        {
            Console.WriteLine(" Circle: Draw() [Color : " + Color + ", X Cor : " + XCor + ", YCor :" + YCor + ", Radius :"
                    + Radius);
        }
    }
}
