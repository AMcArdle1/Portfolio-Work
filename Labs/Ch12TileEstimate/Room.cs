using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12TileEstimate
{
    class Room
    {
        // Instance Variables
        private string _name;
        private int _width;
        private int _length;
        private int _area;
        private int _boxes;

        // Constructor
        public Room(string name, int width, int length, int area, int boxes)
        {
            _name = name;
            _width = width;
            _length = length;
            _area = area;
            _boxes = boxes;
        }

        // Getters
        public string Name => _name;
        public int Width => _width;
        public int Length => _length;
        public int Area => _area;
        public int Boxes
        {
            get
            {
                int temp = (_area / 12);
                _boxes = (_area % 12 == 0) ? temp : ++temp;
                return _boxes;
            }
        }
    }
}
