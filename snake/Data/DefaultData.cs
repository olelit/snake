using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake.Data
{
    class DefaultData
    {

        public static Color ElementColor { get; private set; }
        public static Color HeadElementColor { get; private set; }
        public static int DefaultElementSize { get; private set; }
        public static Point DefaultStartPoint { get; private set; }

        public static int DefaultShift { get; private set; }
        public static void Run()
        {
            ElementColor = Color.Red;
            HeadElementColor = Color.Green;
            DefaultStartPoint = new Point(100, 100);
            DefaultShift = 50;
            DefaultElementSize = 50;
        }
    }
}
