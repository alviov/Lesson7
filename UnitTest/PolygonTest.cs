using System.Collections.Generic;
using Xunit;
using Lesson7_Polygons.Classes;
using System;

namespace UnitTest
{
    public class PolygonTest
    {
        [Fact]
        public void PerimeterTest()
        {
            Point point1 = new Point("point1", 1, 1);
            Point point2 = new Point("point2", 1, 2);
            Point point3 = new Point("point3", 2, 1);
            List<Point> pointCollection = new List<Point>
            {
                point1,
                point2,
                point3
            };
            Polygon poligon = new Polygon(pointCollection);
            double test = poligon.Perimeter();

            Assert.Equal(3.41, Math.Round(test,2));
        }        
    }
}
