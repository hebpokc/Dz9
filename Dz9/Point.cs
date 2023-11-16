using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9
{
    class Point : Figure
    {
        public Point(Colors color, bool pointState) : base(color, pointState) 
        {
            horizCoordinate = 0;
            vertCoordinate = 0;
        }
        public override void MoveHorizontal(double distance)
        {
            horizCoordinate += distance;
        }
        public override void MoveVertical(double distance)
        {
            vertCoordinate += distance;
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
        public override void Print()
        {
            Console.WriteLine($"\nИнфомарция о точке\nКоординаты: ({horizCoordinate},{vertCoordinate})\nЦвет: {color}\nСостояние: {State()}");
        }
    }
}
