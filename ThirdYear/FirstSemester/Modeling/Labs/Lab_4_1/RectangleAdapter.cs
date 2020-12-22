using System;
using System.Drawing;

namespace Lab_4_1
{
    interface IDisplay
    { 
        public Rectangle Display(int topX, int topY, int bottomX, int bottomY);
    }
    
    class RectangleAdapter : IDisplay
    {
        public Rectangle Display(int topX, int topY, int bottomX, int bottomY)
        {
            if (bottomX < topX)
            {
                int tmp = topX;
                topX = bottomX;
                bottomX = tmp;
            }
            if (bottomY < topY)
            {
                int tmp = topY;
                topY = bottomY;
                bottomY = tmp;
            }
            
            int width = bottomX - topX;
            int height = bottomY - topY;

            return new LegacyRectangle().Display(topX, topY, width, height);
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