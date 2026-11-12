using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // alternatief

            // tekst uitlezen naar string variabelen
            /*string sNumber1 = txtNumber1.Text;
            string sNumber2 = txtNumber2.Text;*/

            // label met error standaard onzichtbaar plaatsen
            lblError.Visible = false;

            // try: probeer de code
            // als er iets fout loopt, ga over naar catch
            try
            {
                // twee variabelen van type int maken 
                // in deze variabelen slaan we de cijfers op
                // die uit de textboxes komen
                int iNumber1 = Convert.ToInt32(txtNumber1.Text);
                int iNumber2 = Convert.ToInt32(txtNumber2.Text);

                // variabele voor uitkomst en berekening uitvoeren
                int iResult = iNumber1 + iNumber2;

                // resultaat in onderste textbox txtResult plaatsen
                // int moet opnieuw omgezet worden naar string
                // om in textbox te plaatsen
                txtResult.Text = iResult.ToString();
            }
            catch
            {
                // pop up boodschap met messagebox
                //MessageBox.Show("Oei, je hebt iets verkeerd ingevuld...");
                // label met foutmelding tonen
                lblError.Visible = true;
            }

        }
    }
}
