using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12JobEstimate
{
    class Job
    {
        // Create Constant 
        public decimal TRIPFEE = 35.00m;

        // Instance Variables 
        private string _description;
        private decimal _hoursToComplete;
        private decimal _hourlyFee;
        private decimal _totalFee;

        // Constructor 
        public Job(string description, decimal hoursToComplete, decimal hourlyFee, decimal totalFee)
        {
            _description = description;
            _hoursToComplete = hoursToComplete;
            _hourlyFee = hourlyFee;
            _totalFee = totalFee;
        }

        // Getters 
        public string GetDescription() => _description;
        public decimal GetHTC() => _hoursToComplete;
        public decimal GetHourlyFee() => _hourlyFee;
        public decimal GetTotalFee() => _totalFee;
    }
}
