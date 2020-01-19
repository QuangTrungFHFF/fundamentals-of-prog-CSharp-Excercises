using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08to19
{
    class Screen
    {
        private double size = 0;
        private string colours = null;
        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
        public string Colours
        {
            get
            {
                return this.colours;
            }
            set
            {
                this.colours = value;
            }
        }        
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
        public override string ToString()
        {
            return string.Format("Screen size: {0}, Screen colour: {1}", size, colours);
        }
    }
}
