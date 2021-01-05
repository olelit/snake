using snake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake.Data
{
    class ElementManager
    {
        public static List<Element> Elements { get; private set; }
        public static Element Head { get; private set; }

        public static void Add(Element element)
        {
            if (Elements == null)
            {
                Elements = new List<Element>();
                Head = element;
            }

            Elements.Add(element);
        }

        public static Element Last()
        {
            return Elements.Last();
        }
    }
}
