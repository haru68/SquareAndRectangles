using System;

namespace Geometry
{
    class Polygon
    {
        private double area;

        public void GetArea(double width, double height)
        {
            area = width * area;
        }
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
    }

    class Square : Polygon
    {
        private double side;
            
        public void SetWidth(double width)
        {
            // Because a square must have its sides equal, I also set
            // its height to the given width
            this.side = width;
            this.side = width;
        }

        public void SetHeight(double height)
        {
            // Because a square must have its sides equal, I also set
            // its width to the given height
            this.side = height;
            this.side = height;
        }
    }
}
