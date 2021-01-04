using snake.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake.Core
{
    class App
    {

        private Start _Start;

        public App()
        {
            DefaultData.Run();

            _Start = new Start();
            _Start.Execute();
        }
    }
}
