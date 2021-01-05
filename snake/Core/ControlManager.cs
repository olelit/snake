using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake.Core
{
    class ControlManager
    {

        public static ControlManager Instanse { get; private set; }

        enum Way
        {
            Up,
            Down,
            Left,
            Right
        }

        private Dictionary<Keys, Way> Control = new Dictionary<Keys, Way>();

        Way _Current = Way.Up;

        public ControlManager()
        {
            Control.Add(Keys.W, Way.Up);
            Control.Add(Keys.S, Way.Down);
            Control.Add(Keys.A, Way.Left);
            Control.Add(Keys.D, Way.Right);
            Instanse = this;
        }

        public static void ChangeHeadWay(Keys key)
        {
            Instanse._Current = Instanse.Control[key];
        }

        public Point ConvertToPosition(Point position, int shift)
        {
            switch (_Current)
            {
                case Way.Up:
                    position = new Point(position.X, position.Y - shift);
                    break;
                case Way.Down:
                    position = new Point(position.X, position.Y + shift);
                    break;
                case Way.Left:
                    position = new Point(position.X - shift, position.Y);
                    break;
                case Way.Right:
                    position = new Point(position.X + shift, position.Y);
                    break;
            }
            return position;
        }
    }
}
