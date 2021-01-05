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
        private ControlManager _ControlManager;

        public App()
        {
            DefaultData.Run();

            _Start = new Start();
            _ControlManager = new ControlManager();
            _Start.Execute();
        }
    }
}
