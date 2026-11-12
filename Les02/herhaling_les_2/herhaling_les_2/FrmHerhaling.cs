using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herhaling_les_2
{
    public partial class FrmHerhaling : Form
    {
        public FrmHerhaling()
        {
            InitializeComponent();
        }

        // oefening 1 p. 15
        private void btnHello_Click(object sender, EventArgs e)
        {
            // naam uit textbox halen en opslaan in variabele
            string name = txtName.Text;

            // boodschap samenstellen in aparte variabele
            string message = "Hallo " + name + "!";

            // boodschap tonen in tweede textbox
            txtHello.Text = message;

            // alles in één lijntje
            //txtHello.Text = "Hallo " + txtName.Text + "!";"
        }

        // oefening 2 p. 15
        private void btnSwap_Click(object sender, EventArgs e)
        {
            // versie 1
            string temp = txtSwap1.Text;
            txtSwap1.Text = txtSwap2.Text;
            txtSwap2.Text = temp;

            // versie 2
            /*string text1 = txtSwap1.Text;
            string text2 = txtSwap2.Text;
            txtSwap1.Text = text2;
            txtSwap2.Text = text1;*/
        }

        // extra voorbeeld delen
        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                // cijfers uit textboxes halen
                // en omzetten naar correct data type
                int number1 = Convert.ToInt32(txtNumber1.Text);
                int number2 = Convert.ToInt32(txtNumber2.Text);

                // delen en opslaan in derde variabele
                int result = number1 / number2;

                // resultaat tonen in label
                // cijfer moet weer omgezet worden naar string
                // om in label of textbox te plaatsen
                lblResult.Text = result.ToString();
            }   
            catch
            {
                MessageBox.Show("Oei, er liep iets fout...");
            }
        }

        // extra voorbeeld korting
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            // inlezen van nodige data 
            // en opslaan in variabelen
            decimal originalPrice = Convert.ToDecimal(txtOriginalPrice.Text);
            decimal discountPercentage = Convert.ToDecimal(txtDiscountPercentage.Text);

            // berekenen hoeveel korting ik heb
            // voorbeeld: als ik 100 intyp voor prijs
            // en 10 voor discountpercentage dan is mijn savings
            // ook 10 want 10% van 100 is 10
            // voorbeeld2: als ik 200 intyp voor prijs
            // en 10 voor discountpercentage dan is mijn savings
            // 20 want 10% van 200 is 20
            decimal savings = originalPrice * discountPercentage / 100;

            // final price berekenen
            decimal finalPrice = originalPrice - savings;

            // plaatsen in label
            lblFinalPrice.Text = finalPrice.ToString();
        }
    }
}
