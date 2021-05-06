using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch14_15Letters
{
    public class CertifiedLetter : Letter
    {
        // Instance Variable 
        string _trackingNumber;

        // Constructor
        public CertifiedLetter(string recipient, DateTime sentDate, string trackingNumber) : base (recipient, sentDate)
        {
            _trackingNumber = trackingNumber;
        }

        // Getter and Setter
        public string TrackingNumber => _trackingNumber;

        public override double Price
        {
            get
            {
                return 0.65;
            }
        }

        public override string ToString()
        {
            return base.SentDate.ToString("MM/dd/yyyy") + " " + base.Recipient + " , " + Price.ToString("c") + " , " + TrackingNumber;
        }
    }
}
