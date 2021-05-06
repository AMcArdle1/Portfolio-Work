using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12Paladins
{
    class Champion
    {
        // Instance Variables 
        private readonly string _name;
        private readonly string _type;
        private readonly string _leftMouse;
        private readonly string _rightMouse;
        private readonly string _q;
        private readonly string _f;
        private readonly string _e;

        // Constructor
        public Champion(string name, string type, string leftMouse, string rightMouse, string q, string f, string e)
        {
            _name = name;
            _type = type;
            _leftMouse = leftMouse;
            _rightMouse = rightMouse;
            _q = q;
            _f = f;
            _e = e;
        }

        // Create Getters
        public string GetName() => _name;
        public string GetChampionType() => _type;
        public string GetLeftMouse() => _leftMouse;
        public string GetRightMouse() => _rightMouse;
        public string GetQ() => _q;
        public string GetF() => _f;
        public string GetE() => _e;


    }
}
