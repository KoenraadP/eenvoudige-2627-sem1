using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negative
{
    public partial class FrmNegative : Form
    {
        public FrmNegative()
        {
            InitializeComponent();
        }

        // methode om te controleren of een string
        // kan omgezet worden naar een int
        // result moet true of false zijn
        private bool IsInteger(string input)
        {
            try
            {
                Convert.ToInt32(input);
                // als de convert lukt, gaan we over naar de volgende lijn
                // als de convert niet lukt, gaan we over naar catch
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // eerst controleren of input kan omgezet worden naar int
            if (IsInteger(txtNumber1.Text) == true
                && IsInteger(txtNumber2.Text) == true)
            {
                // kleur label tekst groen maken
                lblResult.ForeColor = Color.Green;

                // inlezen cijfers en converteren
                int number1 = Convert.ToInt32(txtNumber1.Text);
                int number2 = Convert.ToInt32(txtNumber2.Text);

                // als één of beide cijfers onder 0 liggen
                // woord "Negative" in label plaatsen
                // anders woord "Positive" in label plaatsen
                if (number1 < 0 || number2 < 0)
                {
                    lblResult.Text = "Negative";
                }
                else
                {
                    lblResult.Text = "Positive";
                }
            }
            else
            {
                // tekst rood maken
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Voer geldige cijfers in!";
            }
        }
    }
}
