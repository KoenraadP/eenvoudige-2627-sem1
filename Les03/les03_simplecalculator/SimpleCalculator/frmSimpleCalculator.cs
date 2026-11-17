using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class FrmSimpleCalculator : Form
    {

        #region globals

        // globale variabelen --> kunnen gebruikt worden door 
        // alle methodes en blokjes codes
        double number1;
        double number2;

        #endregion

        public FrmSimpleCalculator()
        {
            InitializeComponent();
        }

        #region methods

        // methode om de cijfers te lezen uit
        // de textboxes en deze om te zetten naar double
        // private --> niet belangrijk momenteel, gewoon altijd gebruiken
        // void --> geen return in deze methode
        private void ConvertNumbers()
        {
            // de variabelen werden al gemaakt bovenaan als globals
            // dus moeten niet opnieuw aangemaakt worden
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);
        }

        #endregion

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ConvertNumbers();
            double sum = number1 + number2;
            txtResult.Text = sum.ToString();
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(txtNumber1.Text);
            double number2 = Convert.ToDouble(txtNumber2.Text);

            double difference = number1 - number2;

            txtResult.Text = difference.ToString();
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(txtNumber1.Text);
            double number2 = Convert.ToDouble(txtNumber2.Text);

            double product = number1 * number2;

            txtResult.Text = product.ToString();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(txtNumber1.Text);
            double number2 = Convert.ToDouble(txtNumber2.Text);

            double quotient = number1 / number2;

            txtResult.Text = quotient.ToString();
        }
    }
}
