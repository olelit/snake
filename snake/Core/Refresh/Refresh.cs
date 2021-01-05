using snake.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace snake.Core.Refresh
{
    class Refresh
    {
        private PictureBox _PictureBox;
        private Graphics _G;
        private Bitmap _Bmp;
        private Draw _Draw;
        public Refresh(PictureBox pictureBox)
        {
            _PictureBox = pictureBox;
            _Bmp = new Bitmap(_PictureBox.Width, _PictureBox.Height);
            _G = Graphics.FromImage(_Bmp);
            _Draw = new Draw(_G);
        }

        public void RefreshPictureBox()
        {
            _G.Clear(_PictureBox.BackColor);

            foreach (var element in ElementManager.Elements)
            {
                element.Move();
                _Draw.DrawRect(element);
            }

            _PictureBox.Image = _Bmp;
        }
    }
}
