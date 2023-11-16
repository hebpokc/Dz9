using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dz9
{
    public enum Colors
    {
        Белый,
        Черный,
        Красный,
        Синий,
        Зеленый,
        Желтый,
        Оранжевый,
        Фиолетовый
    }
    abstract class Figure : IFigure
    {
        protected double horizCoordinate;
        protected double vertCoordinate;
        protected Colors color;
        protected bool figureState;
        public double HorizCoordinate
        {
            get
            {
                return horizCoordinate;
            }
            set
            {
                horizCoordinate = value;
            }
        }
        public double VertCoordinate
        {
            get
            {
                return vertCoordinate;
            }
            set
            {
                vertCoordinate = value;
            }
        }
        public Colors Color
        {
            get
            {
                return Color;
            }
            set
            {
                color = value;
            }
        }
        public bool FigureState
        {
            get
            {
                return FigureState;
            }
            set
            {
                figureState = value;
            }
        }
        public Figure(Colors color, bool figureState)
        {
            this.color = color;
            this.figureState = figureState;
        }
        virtual public void MoveHorizontal(double distance)
        {
            horizCoordinate += distance;
        }
        virtual public void MoveVertical(double distance)
        {
            vertCoordinate += distance;
        }
        public void ChangeColor(Colors color)
        {
            this.color = color;
        }
        public abstract string State();
        public abstract void Print();
    }
}
