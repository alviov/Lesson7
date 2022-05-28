using System.Collections.Generic;
using System;
using Xunit;
using Lesson7_Shapes.Classes;


namespace UnitTest_Shapes
{
    public class ShapeTest
    {
        [Fact]
        public void BallVolumeTest()
        {
            Ball ball = new Ball(10);

            Assert.Equal(4188.79, Math.Round(ball.Volume(), 2));
        }

        [Fact]
        public void BoxVolumeTest()
        {
            Box box = new Box(10);

            Assert.Equal(1000, Math.Round(box.Volume(), 2));
        }

        [Fact]
        public void CylinderVolumeTest()
        {
            Cylinder cylinder = new Cylinder(10,10);

            Assert.Equal(3141.59, Math.Round(cylinder.Volume(), 2));
        }

        [Fact]
        public void PyramidVolumeTest()
        {
            Pyramid pyramid = new Pyramid(10, 10);

            Assert.Equal(33.33, Math.Round(pyramid.Volume(), 2));
        }

        [Fact]
        public void BoxSpaceTest()
        {
            Box bigbox = new Box(100);
            Box box = new Box(10);
            Ball ball = new Ball(10);
            Cylinder cylinder = new Cylinder(10, 10);
            Pyramid pyramid = new Pyramid(10, 10);

            List<Shape> shapes = new List<Shape>
            { 
                box,
                ball,
                cylinder,
                pyramid
            };

            Assert.Equal(991636, Math.Round(bigbox.Space(shapes), 0));
        }
        
        [Fact]
        public void BoxAddTest()
        {
            Box bigbox = new Box(10);
            Ball ball = new Ball(10);

            Assert.False(bigbox.Add(ball));
        }

    }
}
