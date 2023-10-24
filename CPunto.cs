using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class CPunto
    {
        private int x;
        private int y;

        public CPunto(int px, int py)
        {
            x= px;
            y= py;
        }

        public override string ToString()
        {
            return String.Format("X={0},Y={1}", x, y);
        }
    }
}
