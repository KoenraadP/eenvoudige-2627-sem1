using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AreaCircle
{
    public partial class frmAreaCircle : Form
    {
        public frmAreaCircle()
        {
            InitializeComponent();
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            // formule = radius * radius * pi
            double radius = Convert.ToDouble(txtRadius.Text);
            double area = radius * radius * Math.PI;
            // afronden tot op 2 cijfers na de komma
            // en in txtResult plaatsen
            txtResult.Text = Math.Round(area, 2).ToString();
        }
    }
}
