using System;

namespace OopLab6
{
    class LineSegment
    {

        private double _x;
        private double _y;



        public LineSegment()
        {
            this._x = 0;
            this._y = 0;
        }

        public LineSegment(double _x, double _y)
        {
            this._x = _x;
            this._y = _y;
        }
        public double X
        {
            get
            { 
                return _x; 
            }
            set
            {
                _x = value; 
            }
        }

        public double Y
        {
            get
            { 
                return _y; 
            }
            set
            { 
                _y = value; 
            }
        }


        public LineSegment Intersect(LineSegment other)
        {
            if (other == null) return null;

            double s1 = Math.Min(this._x, this._y);
            double e1 = Math.Max(this._x, this._y);
            double s2 = Math.Min(other._x, other._y);
            double e2 = Math.Max(other._x, other._y);

            double intersectStart = Math.Max(s1, s2);
            double intersectEnd = Math.Min(e1, e2);

            if (intersectStart <= intersectEnd)
            {
                return new
                    LineSegment(intersectStart, intersectEnd);
            }
            return null;
        }

        // --- (Задание 3) ---


        public static LineSegment operator !(LineSegment s)
        {
            double new_x = s._x;
            double new_y = s._y;

            if (new_x > new_y)
            {


                if (0 <= new_y) new_x = 0;

                else if (new_x <= 0) new_y = 0;

                else { new_x = 0; new_y = 0; }
            }
            return new LineSegment(new_x, new_y);
        }


        public static implicit operator int(LineSegment s)
        {
            return (int)s._y;
        }


        public static explicit operator double(LineSegment s)
        {
            return s._x;
        }


        public static LineSegment operator +(LineSegment s,
            int val)
        {
            LineSegment res = new LineSegment(s._x + val, s._y);

            if (res._x > res._y)
            {
                double t = res._x; res._x =
                    res._y; res._y = t;
            }
            return res;
        }


        public static LineSegment operator +(int val,
            LineSegment s)
        {
            LineSegment res = new LineSegment(s._x, s._y + val);
            if (res._x > res._y)
            { double t = res._x; res._x = res._y; res._y = t; }
            return res;
        }


        public static bool operator >(LineSegment left,
            LineSegment right)
        {
            double lMin = Math.Min(left._x, left._y);
            double lMa_x = Math.Max(left._x, left._y);
            double rMin = Math.Min(right._x, right._y);
            double rMa_x = Math.Max(right._x, right._y);
            return (lMin <= rMin) && (lMa_x >= rMa_x);
        }


        public static bool operator <(LineSegment left,
            LineSegment right)
        {
            return !(left > right);
        }

        public override string ToString()
        {
            return $"[{this._x}; {this._y}]";
        }
    }
}
