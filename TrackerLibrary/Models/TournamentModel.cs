using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        ///<summary>
        /// Represents name of a tournament
        ///</summary>
        public string TournamentName { get; set; }
        ///<summary> 
        /// Represents entry fee for a tournament
        ///</summary>
        public decimal EntryFee { get; set; }
        ///<summary> 
        /// Represents list of teams entered in a tournament
        ///</summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        ///<summary>
        /// Represents list of prizes for winning a tournament
        ///</summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        ///<summary>
        /// Represents list of a list of matchups
        ///</summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        ///<summary>
        /// Represents id of a tournament
        ///</summary>
        public int Id { get; set; }
    }

}