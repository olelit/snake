using snake.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake.Model
{
    public class Element
    {
        public Element Previous { get; protected set; }
        public Point Position { get; protected set; }
        public Point PreviousPosition { get; protected set; }
        public Color BlockColor { get; protected set; }
        public int Size => DefaultData.DefaultElementSize;

        public Element()
        {
            if(ElementManager.Elements != null)
            {
                Element last = ElementManager.Last();
                if (last != null)
                {
                    Position = last.Position;
                    Previous = last;
                }
            }

            PreviousPosition = Position;
            ElementManager.Add(this);
        }

        public virtual void Move()
        {
            Position = Previous.PreviousPosition;
            Previous.ChangePrevPosition();
        }

        public void ChangePrevPosition()
        {
            PreviousPosition = Position;
        }

    }
}
