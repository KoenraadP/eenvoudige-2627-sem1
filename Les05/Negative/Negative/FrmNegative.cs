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

        private void btnCheck_Click(object sender, EventArgs e)
        {
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

            // alternatief
            /*if (number1 >= 0 && number2 >= 0)
            {
                lblResult.Text = "Positive";
            }
            else
            {
                lblResult.Text = "Negative";
            }*/
        }
    }
}
