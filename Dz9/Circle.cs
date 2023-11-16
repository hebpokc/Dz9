using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9
{
    class Circle : Point
    {
        double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public Circle(double radius, Colors color, bool circleState) : base(color, circleState)
        {
            this.radius = radius;

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
            return Math.PI * radius * radius;
        }
        public override void Print()
        {
            Console.WriteLine($"\nИнфомарция о окружности\nРадиус: {radius}\nЦвет: {color}\nСостояние: {State()}\nПлощадь: {Math.Round(Area(), 2)}");
        }
    }
}
