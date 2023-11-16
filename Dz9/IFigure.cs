using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9
{
    interface IFigure
    {
        void MoveHorizontal(double distance);
        void MoveVertical(double distance);
        void ChangeColor(Colors color);
        string State();
    }
}
