namespace Exercise8
{
    internal class Point
    {
        public int _x;
        public int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public static void SwapPoint(Point point, Point otherPoint)
        {
            int x = point._x;
            int y = point._y;
            point._x = otherPoint._x;
            point._y = otherPoint._y;
            otherPoint._x = x;
            otherPoint._y = y;
        }
    }
}
