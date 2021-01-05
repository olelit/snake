using snake.Core;
using snake.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake.Data
{
    class Head: Element
    {
        public int Shift => DefaultData.DefaultShift;

        public Head()
        {
            Position = DefaultData.DefaultStartPoint;
            BlockColor = DefaultData.HeadElementColor;
            //PreviousPosition = Position;
            //ElementManager.Add(this);
        }

        public override void Move()
        {
            Position = ControlManager.Instanse.ConvertToPosition(Position, Shift);
        }
    }
}
