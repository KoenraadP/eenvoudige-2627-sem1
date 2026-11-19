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

        #endregion

        // alle code die moet uitgevoerd worden bij klikken op knop
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ReadInputs();
            // variabele selectedDate 'testen'
            Console.WriteLine(selectedDate);
        }
    }
}
