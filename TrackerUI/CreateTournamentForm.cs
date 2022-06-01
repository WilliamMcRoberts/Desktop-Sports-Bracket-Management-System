using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            //CreateSampleData();
            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeams.Add(new TeamModel { TeamName = "TestingTeam"});
            availableTeams.Add(new TeamModel { TeamName = "YouTeam"});

            selectedTeams.Add(new TeamModel { TeamName = "WowsersTeam"});
            selectedTeams.Add(new TeamModel { TeamName = "ThomasTeam"});


            selectedPrizes.Add(new PrizeModel { PlaceName = "TestPlace" });
            selectedPrizes.Add(new PrizeModel { PlaceName = "HorriblePlace"});


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
    }
}
