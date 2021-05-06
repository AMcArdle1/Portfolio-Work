using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12Conferences
{
    class Conference
    {
        // Instance Variables
        private string _groupName;
        private DateTime _startingDate;
        private int _attendees;
        private int _room;

        // Constructor 
        public Conference(string groupName, DateTime startingDate ,int attendees, int room)
        {
            _groupName = groupName;
            _startingDate = startingDate;
            _attendees = attendees;
            _room = room;
        }

        // Getters
        public string GetGroupName() => _groupName;
        public DateTime GetStartingDate() => _startingDate;
        public int GetAttendees() => _attendees;
        public int GetRoomNumber() => _room;
    }
}
