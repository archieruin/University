using System;
using System.Drawing;

namespace Lab_4_1
{

    class RectangleAdapter
    {
        public Rectangle Display(int topX, int topY, int bottomX, int bottomY)
        {
            // topLeft: topX, topY
            // topRight: bottomX, topY
            // bottomLeft: topX, bottomY
            int width = (int) Math.Sqrt(Math.Pow((bottomX - topX), 2) + Math.Pow((topY - topY), 2));
            int height = (int) Math.Sqrt(Math.Pow((topX - topX), 2) + Math.Pow((bottomY - topY), 2));
            return new Rectangle(topX, topY, width, height);
        }
    }

    class LegacyRectangle
    {
        public Rectangle Display(int x, int y, int width, int height)
        {
            return new Rectangle(x, y, width, height);
        }
    }
}