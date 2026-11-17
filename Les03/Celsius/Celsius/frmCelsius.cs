using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius
{
    public partial class frmCelsius : Form
    {
        public frmCelsius()
        {
            InitializeComponent();
        }

        // knop om van celsius naar fahrenheit te gaan
        private void BtnCelsius_Click(object sender, EventArgs e)
        {
            // graden celsius lezen uit textbox
            double celsius = Convert.ToDouble(txtCelsius.Text);
            // omzetten naar fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;
            // resultaat tonen in txtResult
            txtResult.Text = fahrenheit.ToString();
        }

        // knop om van fahrenheit naar celsius te gaan
        private void BtnFahrenheit_Click(object sender, EventArgs e)
        {
            double fahrenheit = Convert.ToDouble(txtFahrenheit.Text);
            double celsius = (fahrenheit - 32) * 5 / 9;
            txtResult.Text = celsius.ToString();
        }
    }
}
