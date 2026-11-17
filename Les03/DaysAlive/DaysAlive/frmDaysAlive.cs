using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaysAlive
{
    public partial class frmDaysAlive : Form
    {
        public frmDaysAlive()
        {
            InitializeComponent();
        }

        private void BtnDays_Click(object sender, EventArgs e)
        {
            // invoer (input) lezen
            //int day = Convert.ToInt32(txtDay.Text);
            //int month = Convert.ToInt32(txtMonth.Text);
            //int year = Convert.ToInt32(txtYear.Text);

            // geboortedatum aanmaken in aparte variabele
            //DateTime birthDate = new DateTime(year, month, day);
            // werken met datetimepicker
            DateTime birthDate = dateTimePicker.Value;

            // testen in output of datum correct gemaakt werd
            //Console.WriteLine(birthDate.ToString());

            // variabele voor 'nu' (vandaag)
            DateTime today = DateTime.Now;

            // tijd berekenen tussen twee datums
            // hiervoor doe je gewoon recente datum - oude datum
            TimeSpan timeBetween = today - birthDate;

            // testen wat er uit komt in output
            //Console.WriteLine(timeBetween);

            // output, enkel maar dagen er uit halen
            txtResult.Text = timeBetween.Days.ToString();
        }
    }
}
