using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeLost
{
    public partial class FrmTimeLost : Form
    {
        #region globals

        double hoursPerDay;
        DateTime selectedDate;
        DateTime releaseDate = new DateTime(2026,11,19);

        #endregion

        public FrmTimeLost()
        {
            InitializeComponent();
        }

        // region voor eigen methodes
        #region methods

        // methode om alle 'input' te lezen 
        // en te koppelen aan variabelen
        private void ReadInputs()
        {
            hoursPerDay = Convert.ToDouble(txtHoursPerDay.Text);
            // met de .Date property heb ik enkel de datum, standaard op middernacht 00:00
            selectedDate = dtpDate.Value.Date;
        }

        // methode om te berekenen hoeveel dagen
        // er tussen twee specifieke datums zitten (dit zijn de parameters)
        // dit aantal dagen is de 'uitkomst' van de methode
        // dit is dan het 'aantal dagen dat we gespeeld hebben'
        private int CalculateDaysPlayed(DateTime startDate, DateTime endDate)
        {
            TimeSpan timeBetween = endDate - startDate;
            int daysBetween = timeBetween.Days;
            return daysBetween;
        }

        // methode om te berekenen hoeveel uur je al 'verloren' hebt
        // na x aantal dagen x aantal uur te spelen (parameters)
        private double CalculateHoursLost(int days, double hours)
        {
            double totalHours = days * hours;
            return totalHours;
        }

        // methode om uitvoer (output) zin te maken voor het eindresultaat
        private string Output(int days, double hours)
        {
            string output = "Na " + days + " dagen release van GTA VI "
                            + "ben ik " + hours + " uren van mijn leven kwijt.";
            return output;
        }

        #endregion

        // alle code die moet uitgevoerd worden bij klikken op knop
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ReadInputs();
            // methode uitvoeren om te berekenen hoeveel dagen
            // er tussen release en geselecteerde datum zitten
            int daysPlayed = CalculateDaysPlayed(releaseDate, selectedDate);
            // methode uitvoeren om te berekenen hoeveel
            // uur ik dan in totaal al gespeeld heb
            double hoursLost = CalculateHoursLost(daysPlayed, hoursPerDay);
            // output tonen
            txtOutput.Text = Output(daysPlayed, hoursLost);
        }
    }
}
