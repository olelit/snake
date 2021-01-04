using snake.Core;
using snake.Core.Refresh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class Form1 : Form
    {
        readonly App _Main;
        readonly Refresh _Refresh;

        public Form1()
        {
            _Main = new App();
 
            InitializeComponent();
            _Refresh = new Refresh(pictureBox1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            _Refresh.RefreshPictureBox();
        }
    }
}
