using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamsFile = "TeamModels.csv";

        public PersonModel CreatePerson(PersonModel person)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            // Find the max id + 1
            int currentId = 1;

            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            person.Id = currentId;

            // Add the new record with the new id
            people.Add(person);

            // Convert the prizes list to a list of strings
            // Save the list to the txt file
            people.SaveToPeopleFile(PeopleFile);

            return person;
        }

        /// TODO - Wire up the CreatePrize for text files
        /// <summary>
        /// Saves a new prize to the text file and returns info
        /// </summary>
        /// <param name="prize">Prize info</param>
        /// <returns>Prize info including unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel prize)
        {
            // Load the txt file and Convert the txt to list of prize models
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max id + 1
            int currentId = 1;
            
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            prize.Id = currentId;

            // Add the new record with the new id
            prizes.Add(prize);
            
            // Convert the prizes list to a list of strings
            // Save the list to the txt file
            prizes.SaveToPrizesFile(PrizesFile);

            return prize;
        }

        public TeamModel CreateTeam(TeamModel team)
        {
            List<TeamModel> teams = TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
            // Find the max id + 1
            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            
            team.Id = currentId;
            
            // add the new record with the new id
            teams.Add(team);

            // Convert the teams list to a list of strings
            // Save the list to the txt file
            teams.SaveToTeamsFile(TeamsFile);

            return team;
        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public List<TeamModel> GetTeams_All()
        {
            throw new NotImplementedException();
        }
    }
}
