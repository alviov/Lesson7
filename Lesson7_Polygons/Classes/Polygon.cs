using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Polygons.Classes
{
    public class Polygon
    {
        List<Point> _pointCollection { get; }
        public Polygon(List<Point> pointCollection)
        {
            _pointCollection = pointCollection;
        }
        public double Perimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < _pointCollection.Count; i++)
            {
                if (i == _pointCollection.Count - 1)
                {
                    perimeter += Math.Sqrt(Math.Pow((_pointCollection[0].GetXCoordinate() - _pointCollection[i].GetXCoordinate()), 2) + Math.Pow((_pointCollection[0].GetYCoordinate() - _pointCollection[i].GetYCoordinate()), 2));
                }
                else
                {
                    perimeter += Math.Sqrt(Math.Pow((_pointCollection[i + 1].GetXCoordinate() - _pointCollection[i].GetXCoordinate()), 2) + Math.Pow((_pointCollection[i + 1].GetYCoordinate() - _pointCollection[i].GetYCoordinate()), 2));
                }
            }
            return perimeter;
        }

        public void ShowPerimeter()
        {
            Console.WriteLine($"For the figure formed from identified points perimeter is: {Perimeter(),2:F}");
        }
    }
}
