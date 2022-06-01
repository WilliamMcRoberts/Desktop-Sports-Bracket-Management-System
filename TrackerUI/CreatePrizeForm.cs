using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }


        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel prize = new PrizeModel(
                    placeNameTextBox.Text,
                    placeNumberTextBox.Text,
                    prizeAmountTextBox.Text,
                    prizePercentageTextBox.Text);

                GlobalConfig.Connection.CreatePrize(prize);

                callingForm.PrizeComplete(prize);

                this.Close();

            }
            else
            {
                MessageBox.Show("You have entered invalid information...Please fix and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberTextBox.Text, out placeNumber);
            
            if (!placeNumberValidNumber)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            int prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountTextBox.Text, out prizeAmount);
            bool prizePercentageValid = int.TryParse(prizePercentageTextBox.Text, out prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if (prizeAmount <=0 && prizePercentage <= 0)
            {
                return false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                return false;
            }

            return output;
        }
    }
}
