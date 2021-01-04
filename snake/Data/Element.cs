using snake.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake.Model
{
    class Element
    {
        public Element Previous { get; private set; }
        public Point Position { get; private set; }
        public Color BlockColor { get; private set; }
        public int Size => DefaultData.DefaultElementSize;

        public Element()
        {
            Position = DefaultData.DefaultStartPoint;
            BlockColor = DefaultData.HeadElementColor;
            ElementManager.Add(this);
        }

        public Element(Element previous, Point position)
        {
            ElementManager.Add(this);
        }

    }
}
