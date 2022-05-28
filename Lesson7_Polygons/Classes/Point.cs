using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Polygons.Classes
{
    public class Point
    {
        string Name { get; }
        double X { get; }
        double Y { get; }

        public Point(string Name, double X, double Y)
        {
            this.Name = Name;
            this.X = X;
            this.Y = Y;
        }

        public void ShowCoordinates()
        {
            Console.WriteLine($"Point{Name} coordinates are: \n X={X} \t Y={Y}");
        }

        public double GetXCoordinate()
        {
            return X;
        }

        public double GetYCoordinate()
        {
            return Y;
        }
    }
}
