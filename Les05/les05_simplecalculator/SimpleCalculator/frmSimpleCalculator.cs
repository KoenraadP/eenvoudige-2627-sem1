using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class FrmSimpleCalculator : Form
    {
        #region globals

        double number1;
        double number2;

        #endregion

        public FrmSimpleCalculator()
        {
            InitializeComponent();
        }

        #region methodes

        private void ReadNumbers()
        {
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);
        }

        // methode om berekening te doen met de twee cijfers
        // het 'soort' berekening wordt ook meegegeven als parameter
        private double Calculate(double nr1, double nr2, string operation) // operation is dan bvb "+", "-", "x", ":"
        {
            // variabele voor uiteindelijke resultaat
            // standaard al waarde geven -> 'initialiseren' 
            double result = 0;

            if (operation == "+")
            {
                result = nr1 + nr2;
            }
            else if (operation == "-")
            {
                result = nr1 - nr2;
            }
            else if (operation == "x")
            {
                result = nr1 * nr2;
            }
            else if (operation == ":")
            {
                result = nr1 / nr2;
            }
            else
            {
                // foutmelding als de operation geen van de vier mogelijkheden is
                throw new Exception("Ongeldige bewerking");
            }

            // uitkomst als return
            return result;
        }

        #endregion

        #region events

        private void Btn_Click(object sender, EventArgs e)
        {
            string output = "";
            try
            {
                ReadNumbers();
                // sender --> element dat aangeklikt werd
                // maar wordt nog niet gezien als Button dus zetten we om naar Button
                double result = Calculate(number1, number2, ((Button)sender).Text);
                //double result = Calculate(number1, number2, (sender as Button).Text); // alternatief
                output = result.ToString();
            }
            catch (Exception ex)
            {
                output = ex.Message;
            }

            txtResult.Text = output;
        }    

        #endregion
    }
}
