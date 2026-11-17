using System.Windows.Forms;

namespace Swap
{
    public partial class FrmSwap : Form
    {
        public FrmSwap()
        {
            InitializeComponent();
        }

        // schrijf een methode met de naam SwapText()
        // deze methode moet de inhoud (text) van twee
        // opgegeven textboxes wisselen
        // koppel deze methode uiteindelijk aan de knop
        private void SwapText(TextBox box1, TextBox box2)
        {
            string text1 = box1.Text;
            string text2 = box2.Text;

            box1.Text = text2;
            box2.Text = text1;
        }

        private void btnSwap_Click(object sender, System.EventArgs e)
        {
            // gebruiken van methode
            SwapText(txtFirst, txtSecond);
        }
    }
}
