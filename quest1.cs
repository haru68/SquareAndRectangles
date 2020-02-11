using System;

namespace Geometry
{
    public abstract class Polygon
    {
        public abstract double GetArea();
    }


    class Rectangle : Polygon
    {
        private double width;
        private double height;

        public void SetWidth(double width)
        {
            this.width = width;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetHeight()
        {
            return height;
        }

        public override double GetArea()
        {
            double area = height * width;
            return area;
        }
    }

    class Square : Polygon
    {
        private double _side;
            
        public void SetWidth(double side)
        {
            this._side = side;
        }

        public override double GetArea()
        {
            double area = _side * _side;
            return area;
        }
    }
}
