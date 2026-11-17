using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageOfFour
{
    public partial class FrmAverage : Form
    {
        // globals om te gebruiken bij de uitwerking van de opdracht
        double dNr1, dNr2, dNr3, dNr4;

        private void btnAvg_Click(object sender, EventArgs e)
        {
            // input met methode
            ConvertNumbers();
            // bewerking met methode
            double result = AverageOfFour(dNr1, dNr2, dNr3, dNr4);
            // output met methode
            txtResult.Text = Output(result);
        }

        public FrmAverage()
        {
            InitializeComponent();
        }

        // methode om iets te testen :)
        private string VeryLargeNumber()
        {
            int length = 309;
            string largeNumber = new string('9', length);
            return largeNumber;
        }

        // maak de drie methodes waarvoor je hieronder de beschrijvingen vindt
        // koppel daarna deze methodes op een correcte manier aan de knop

        // schrijf een methode die de variabelen dNr1, dNr2, dNr3 en dNr4
        // een waarde toekent: de inhoud van de vier textboxes, omgezet naar
        // double formaat
        private void ConvertNumbers()
        {
            dNr1 = Convert.ToDouble(txtOne.Text);
            dNr2 = Convert.ToDouble(txtTwo.Text);
            dNr3 = Convert.ToDouble(txtThree.Text);
            dNr4 = Convert.ToDouble(txtFour.Text);
        }

        // schrijf een methode die het gemiddelde berekent van
        // vier opgegeven double cijfers
        // het gemiddelde moet uit de methode komen als 'uitkomst'
        private double AverageOfFour(double d1, double d2, double d3, double d4)
        {
            double sum = d1 + d2 + d3 + d4;
            double average = sum / 4;
            return average;
        }


        // schrijf een methode die een tekst zin maakt
        // "Het gemiddelde is ..."
        // op het einde van deze zin wordt een cijfer getoond
        // dit cijfer wordt ingevoerd bij het aanroepen van de methode
        private string Output(double avg)
        {
            string output = "Het gemiddelde is " + avg;
            return output;
        }
    }
}
