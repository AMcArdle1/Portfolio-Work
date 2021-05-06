using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch14_15Photos
{
    public class FramedPhoto : Photo
    {
        // Material enumerator
        public enum Material
        {
            PINE = 0,
            OAK = 1,
            STEEL = 2,
            SILVER = 3,
            GOLD = 4
        }

        // Style enumerator
        public enum Style
        {
            SIMPLE = 0,
            MODERN = 1,
            ANTIQUE = 2,
            VINTAGE = 3,
            ECLECTIC = 4
        }

        // Instance Variables 
        Material _theMaterial;
        Style _theStyle;

        // Constructor
        public FramedPhoto (double width, double height, Material material, Style style) : base (width, height)
        {
            _theMaterial = material;
            _theStyle = style;
        }

        // Getters and Setters
        public Material TheMaterial => _theMaterial;
        public Style TheStyle => _theStyle;

        public override string ToString()
        {
            return base.ToString() + " Framed " + TheMaterial.ToString() + " " + TheStyle.ToString();
        }
    }
}
