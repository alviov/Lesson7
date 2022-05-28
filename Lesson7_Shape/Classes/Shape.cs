using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Shapes.Classes
{
    public abstract class Shape
    {
        public enum ShapeForm { Box, Ball, Cylinder, Pyramid }
        public virtual double Volume()
        {
            return default;
        }
        public virtual void ShowParameters()
        {

        }
    }
}
