using snake.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake.Core
{
    class Draw
    {

        private Graphics _G;

        public Draw(Graphics g)
        {
            _G = g;
        }

        public void DrawRect(Element element)
        {
            Rectangle rect = new Rectangle(element.Position, new Size(element.Size, element.Size));
            _G.FillRectangle(new SolidBrush(element.BlockColor), rect);
        }
    }
}
