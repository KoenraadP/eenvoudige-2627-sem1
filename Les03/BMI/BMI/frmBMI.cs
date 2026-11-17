using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }

        // let op: invoer bij height moet met komma gebeuren
        // niet met een punt! (wegens Belgisch regionale instellingen PC)
        // alternatieve oplossing: invoer in centimeter en dan delen door 100
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // input lezen
            double weight = Convert.ToDouble(txtWeight.Text);
            double height = Convert.ToDouble(txtHeight.Text);

            // berekening doen
            double bmi = weight / (height * height);

            // uitvoer, afgerond
            txtResult.Text = Math.Round(bmi).ToString();
        }
    }
}
