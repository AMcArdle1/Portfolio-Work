using System;
using System.Windows.Forms;

namespace Ch10JobDatabase
{
    public partial class FormSR : Form
    {
        public FormSR(int index)
        {
            InitializeComponent();
            linkLabelJobResults.Text += jobs[index];
        }


        string[] jobs = {"Entry Level IT Internship",
                               "Manufactoring Technician",
                               "Chemical Product Engineer",
                               "HVAC Installer",
                               "Automotive Technician" };

    }
}
