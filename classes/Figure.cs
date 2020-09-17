using System;
using System.Collections.Generic;
using System.Text;

namespace LB_2.classes
{
    class Point
    {
        int _point1;
        int _point2;
        string _pointName;

        public Point(int point1, int point2, string pointName)
        {
            this._point1 = point1;
            this._point2 = point2;
            this._pointName = pointName;
        }
        public int Point1
        {
            get
            {
                return _point1;
            }
            set { }
        }
        public int Point2
        {
            get
            {
                return _point2;
            }
            set { }
        }
        public string PointName
        {
            get
            {
                return _pointName;
            }
            set { }
        }
    }
    class Figure
    {
        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private Point E;
        public string _name;

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public Figure(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this._name = "трикутник";
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this._name = "чотирикутник";
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
            this._name = "п'ятикутник";
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt((B.Point1 - A.Point1) * (B.Point1 - A.Point1) + (B.Point2 - A.Point2) * (B.Point2 - A.Point2));
        }
        public void PerimeterCalculator()
        {
            double perimeter;
            if (E != null)
            {
                perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E) + LengthSide(E, A);
            }
            else if (D != null)
            {
                perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E); 
            }
            else 
            {
                perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A); 
            }

            Console.WriteLine($"Периметр {Name}a: {perimeter}");
        }
    }
}
