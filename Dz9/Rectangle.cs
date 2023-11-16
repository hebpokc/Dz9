using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9
{
    class Rectangle : Point
    {
        double height;
        double width;
        public Rectangle(double height, double width, Colors color, bool rectangleState) : base(color, rectangleState)
        {
            this.height = height;
            this.width = width;
        }
        public override string State()
        {
            if (figureState)
            {
                return "Видимое";
            }
            else
            {
                return "Невидимое";
            }
        }
        public double Area()
        {
            return width * height;
        }
        public override void Print()
        {
            Console.WriteLine($"\nИнфомарция о прямоугольнике\nВысота: {height}\nШирина: {width}\nЦвет: {color}\nСостояние: {State()}\nПлощадь: {Math.Round(Area(), 2)}");
        }
    }
}
