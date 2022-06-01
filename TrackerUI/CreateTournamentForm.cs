
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeams_All();
        List<TeamModel> selectedTeams = new();
        List<PrizeModel> selectedPrizes = new();

        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }


        private void WireUpLists()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void tournamentNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void teamsPlayersLabel_Click(object sender, EventArgs e)
        {

        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel team = (TeamModel)selectTeamDropDown.SelectedItem;

            if (team != null)
            {
                availableTeams.Remove(team);
                selectedTeams.Add(team);

                WireUpLists();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // Call create prize form
            CreatePrizeForm form = new(this);
            form.Show();
            

        }

        public void PrizeComplete(PrizeModel prize)
        {
            // Get back a prize model
            // Put prize model into list of selected prizes
            selectedPrizes.Add(prize);
            WireUpLists();
        }

        private void removeSelectedTeamPlayerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
