using System;
using System.Windows.Forms;

namespace Salary_Projection_GUI_App_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            try
            {

                //decimal CPL;
                decimal CP = decimal.Parse(priceTxtBx.Text);
                decimal r = decimal.Parse(interestTxtBx.Text);
                int n = int.Parse(yearsTxtBx.Text);
                double interest = (double)r;
                double price = (double)CP;





                answerLbl.Text = "$" + (price * Math.Pow(1 + (interest / 100 / 365), n * 365)).ToString("n2");


            }
            catch
            {
                answerLbl.Text = "";
                MessageBox.Show("Error while calculating the Car loan Price\nPlease check your input");
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            priceTxtBx.Text = "";
            interestTxtBx.Text = "";
            yearsTxtBx.Text = "";
            answerLbl.Text = "";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
