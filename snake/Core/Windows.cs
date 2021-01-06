using snake.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake.Core
{
    class Windows
    {
        public static Windows Instanse { get; private set; }

        public Size _Size { get; set; }

        public Windows(PictureBox pictureBox)
        {
            _Size = new Size(pictureBox.Width, pictureBox.Height);
            Instanse = this;
        }

        public Point TeleportToAnotherBorder(Point position)
        {
            if (position.X < 0)
                return new Point(_Size.Width - DefaultData.DefaultShift, position.Y);

            if(position.X > _Size.Width)
                return new Point(DefaultData.DefaultShift, position.Y);

            if (position.Y > _Size.Height)
                return new Point(position.X, DefaultData.DefaultShift);

            if (position.Y < 0)
                return new Point(position.X, _Size.Height - DefaultData.DefaultShift);

            return position;
        }
    }
}
