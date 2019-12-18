using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08to19
{
    class Screen
    {
        private double size = 0;
        private string colours = null;
        public Screen()
        {
            this.size = 0;
            this.colours = null;
        }
        public Screen(double size, string colours)
        {
            this.size = size;
            this.colours = colours;
        }
    }
}
