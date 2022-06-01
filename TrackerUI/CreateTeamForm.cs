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
    public partial class CreateTeamForm : Form
    {
        public List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        public List<PersonModel> selectedTeamMembers = new();
        public CreateTeamForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
        }


        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Steph", LastName = "Vonder" });
            availableTeamMembers.Add(new PersonModel { FirstName = "You", LastName = "Me" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jacob", LastName = "Jackenhimer" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Thomas", LastName = "Enging" });
        }

        public void WireUpLists() //TODO - See if there's a better way to refresh lists
        {
            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void entryFeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel person = new();
                person.FirstName = firstNameTextBox.Text;
                person.LastName = lastNameTextBox.Text;
                person.EmailAddress = emailTextBox.Text;
                person.CellPhoneNumber = cellPhoneTextBox.Text;

                selectedTeamMembers.Add(person);
                WireUpLists();

                person = GlobalConfig.Connection.CreatePerson(person);

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                emailTextBox.Text = "";
                cellPhoneTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill out all of the fields");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameTextBox.Text.Length == 0)
            {
                return false;
            }

            if (lastNameTextBox.Text.Length == 0)
            {
                return false;
            }

            if (emailTextBox.Text.Length == 0)
            {
                return false;
            }

            if (cellPhoneTextBox.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel person = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (person != null)
            {
                availableTeamMembers.Remove(person);
                selectedTeamMembers.Add(person);

                WireUpLists(); 
            }
            
        }

        private void removeSelectedButton_Click(object sender, EventArgs e)
        {
            PersonModel person = (PersonModel)teamMembersListBox.SelectedItem;

            if (person != null)
            {
                selectedTeamMembers.Remove(person);
                availableTeamMembers.Add(person);

                WireUpLists(); 
            }
            
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel team = new();

            team.TeamName = teamNameTextBox.Text;
            team.TeamMembers = selectedTeamMembers;

            team = GlobalConfig.Connection.CreateTeam(team);

            // TODO - If we aren't closing this form after creation, reset the form
        }
    }
}
