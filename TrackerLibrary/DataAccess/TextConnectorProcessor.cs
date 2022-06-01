using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

// Load the txt file--*
// Convert the txt to list of prize models--*
// Find the max id
// Add the new record with the new id (max + 1)
// Convert the lprizes to a list of strings
// Save the list to the txt file

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        // Extension method to load the full file path of a file
        public static string FullFilePath(this string fileName)
        {
            // Refers to App.Config file...<appSettings><appSettings/>
            // Example file path...E:\data\TournamentTracker\PrizeModel.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }
        // Extension method to return list of all the lines to be put in text file
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file)) 
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        // Extension method to convert list of lines to list of prize model
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel prize = new();
                prize.Id = int.Parse(cols[0]);
                prize.PlaceNumber = int.Parse(cols[1]);
                prize.PlaceName = cols[2];
                prize.PrizeAmount = decimal.Parse(cols[3]);
                prize.PrizePercentage = double.Parse(cols[4]);
                output.Add(prize);
            }
            return output;
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel person = new();
                person.Id = int.Parse(cols[0]);
                person.FirstName = cols[1];
                person.LastName = cols[2]; ;
                person.EmailAddress = cols[3];
                person.CellPhoneNumber = cols[4];
                output.Add(person);

            }
            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            List<TeamModel> output = new();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();


            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel team = new();
                team.Id = int.Parse(cols[0]);
                team.TeamName = cols[1];

                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                {
                    team.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(team);
            }
            return output;
        }

        public static void SaveToPrizesFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new();
            
            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");

                
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellPhoneNumber}");

                
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTeamsFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new();

            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");

                
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";

            if (people.Count == 0)
            {
                return "";
            }
            foreach (PersonModel person in people)
            {
                output += $"{person.Id}|";
            }
            
            output = output.Substring(0, output.Length - 1);

            return output;
        }




    }
}
