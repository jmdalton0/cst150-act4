using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act4
{
    public partial class SecondsConverter : Form
    {
        public SecondsConverter()
        {
            InitializeComponent();
        }

        // convert user-entered number of seconds to minutes, hours, or days
        private void convertButton_Click(object sender, EventArgs e)
        {
            int numSeconds = 0;
            String input = numSecondsTextBox.Text;

            if (int.TryParse(input, out numSeconds) && numSeconds > 0)
            {
                if (numSeconds < 60)
                {
                    resultTextBox.Text = numSeconds.ToString() + " second(s)";
                } 
                else if (numSeconds < 3600)
                {
                    int numMinutes = numSeconds / 60;
                    resultTextBox.Text = numMinutes.ToString() + " minute(s)";
                }
                else if (numSeconds < 86400)
                {
                    int numHours = numSeconds / 3600;
                    resultTextBox.Text = numHours.ToString() + " hour(s)";
                }
                else
                {
                    int numDays = numSeconds / 86400;
                    resultTextBox.Text = numDays.ToString() + " day(s)";
                }
            }
            else
            {
                MessageBox.Show("Please enter a positive integer.");
                numSecondsTextBox.Text = "";
                resultTextBox.Text = "";
            }
        }
    }
}
