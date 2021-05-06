using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch14_15Photos
{
    public class MattedPhoto : Photo
    {
        // Color enumerator
        public enum Color
        {
            BLACK = 0,
            RED = 1,
            GREEN = 2,
            BLUE = 4,
            WHITE = 7
        }

        // Instance Variable
        Color _theColor;

        // Consructor
        public MattedPhoto(double width, double height, Color color) : base (width, height)
        {
            _theColor = color;
        }

        // Getter and Setter 
        public Color TheColor => _theColor;

        public override string ToString()
        {
            return base.ToString() + " Matted " + TheColor.ToString(); 
        }
    }
}
