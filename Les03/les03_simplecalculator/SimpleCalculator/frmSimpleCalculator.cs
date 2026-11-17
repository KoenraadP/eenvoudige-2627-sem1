using System;
using System.Drawing.Imaging;
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

        // methode om twee double getallen op te tellen
        // type methode is double want uitkomst van optelling is 
        // hier ook double
        // de parameters zijn de twee getallen die opgeteld worden
        private double Add(double nr1, double nr2)
        {
            ConvertNumbers();
            // berekening doen
            double result = nr1 + nr2;
            // uitkomst als return waarde van methode
            return result;
        }

        private double Subtract(double nr1, double nr2)
        {
            double result = nr1 - nr2;
            return result;
        }

        private double Multiply(double nr1, double nr2)
        {
            double result = nr1 * nr2;
            return result;
        }

        private double Divide(double nr1, double nr2)
        {
            double result = nr1 / nr2;
            return result;
        }

        #endregion

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ConvertNumbers();
            double sum = Add(number1, number2);
            txtResult.Text = sum.ToString();
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            ConvertNumbers();
            double difference = Subtract(number1, number2);
            txtResult.Text = difference.ToString();
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            ConvertNumbers();
            double product = Multiply(number1, number2);
            txtResult.Text = product.ToString();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            ConvertNumbers();
            double quotient = Divide(number1, number2);
            txtResult.Text = quotient.ToString();
        }
    }
}
