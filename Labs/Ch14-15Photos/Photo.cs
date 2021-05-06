using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch14_15Photos
{
    public class Photo
    {
        // Instance Variables
        double _width;
        double _height;

        // Constructor
        public Photo(double width, double height)
        {
            this._width = width;
            this._height = height;
        }


        // Getters and setters
        public double Width => _width;
        public double Height => _height;

        public override string ToString()
        {
            return (Width + " x " + Height);
        }

    }
}
