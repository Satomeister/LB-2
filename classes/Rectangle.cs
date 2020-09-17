using System;
using System.Collections.Generic;
using System.Text;

namespace LB_2.classes
{
    class Rectangle
    {
        double _side1;
        double _side2;
        public Rectangle(double side1, double side2)
        {
            this._side1 = side1;
            this._side2 = side2;
        }
        public double AreaCalculator()
        {
            return _side1 * _side2;
        }
        public double PerimeterCalculator()
        {
            return (_side1 + _side2) * 2;
        }

        public double Area {
            get {
                    return AreaCalculator();
                } 
            set {}
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
            set { }
        }
    }
}
