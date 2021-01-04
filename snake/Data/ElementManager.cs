using snake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake.Data
{
    class ElementManager
    {
        public static List<Element> Elements { get; private set; }

        public static void Add(Element element)
        {
            if (Elements == null)
                Elements = new List<Element>();

            Elements.Add(element);
        }
    }
}
