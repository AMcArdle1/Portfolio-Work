using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12FoodOrder
{
    class Order
    {
        // Instance Variables
        private string _name;
        private bool _sundae;
        private bool _soda;

        // Constructor
        public Order (string name, bool hasSundae, bool hasSoda)
        {
            _name = name;
            _sundae = hasSundae;
            _soda = hasSoda;
        }

        // Create Getters
        public string GetName() => _name;
        public bool GetSundae() => _sundae;
        public bool GetSoda() => _soda;

    }
}
