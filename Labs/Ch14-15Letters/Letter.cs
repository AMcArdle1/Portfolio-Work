using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch14_15Letters
{
    public class Letter
    {
        // Instance Variables 
        string _recipient;
        DateTime _sentDate;
        readonly double _price;

        // Constructor
        public Letter(string recipient, DateTime sentDate)
        {
            _recipient = recipient;
            _sentDate = sentDate;
        }

        // Getters and Setters
        public string Recipient => _recipient;
        public DateTime SentDate => _sentDate;

        public virtual double Price => 0.55;

        public override string ToString()
        {
            return (SentDate.ToString("MM/dd/yyyy") + " " + Recipient + " , " + Price.ToString("c"));
        }
    }
}
