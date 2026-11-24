using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsForDinner
{
    public partial class FrmDinner : Form
    {
        public FrmDinner()
        {
            InitializeComponent();
        }

        // code wordt uitgevoerd wanneer een dag uit 
        // de kalender geselecteerd wordt
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // volledige datum uit kalender halen
            DateTime selectedDate = dtpDate.Value;
            // enkel dag uit datum halen
            DayOfWeek day = selectedDate.DayOfWeek; // Monday, Tuesday, ...

            // variabele voor output
            string output;

            // alternatief met if
            /*if (day == DayOfWeek.Monday) output = "spaghetti";
            if (day == DayOfWeek.Tuesday) output = "worst";
            ...
             */

            // met code blokjes
            /*if (day == DayOfWeek.Monday)
            {
                output = "spaghetti";
            }
            if (day == DayOfWeek.Tuesday)
            {
                output = "worst";
            }
            ...
             */

            switch (day)
            {
                case DayOfWeek.Monday:
                    output = "spaghetti";
                    break;
                case DayOfWeek.Tuesday:
                    output = "worst";
                    break;
                case DayOfWeek.Wednesday:
                    output = "vis";
                    break;
                case DayOfWeek.Thursday:
                    output = "biefstuk";
                    break;
                case DayOfWeek.Friday:
                    output = "pizza";
                    break;
                case DayOfWeek.Saturday:
                    output = "kip";
                    break;
                case DayOfWeek.Sunday:
                    output = "spek";
                    break;
                default:
                    output = "hier is iets fout gelopen...";
                    break;
            }

            // output tonen
            txtDinner.Text = output;
        }
    }
}
