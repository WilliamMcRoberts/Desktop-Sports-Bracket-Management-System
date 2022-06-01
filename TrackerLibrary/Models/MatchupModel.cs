using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        ///<summary>
        /// Represents list of matchup entries
        ///</summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        ///<summary>
        /// Represents winning team of a matchup
        ///</summary>
        public TeamModel Winner { get; set; }
        ///<summary>
        /// Represents current round of matchups
        ///</summary>
        public int MatchupRound { get; set; }
        ///<summary>
        /// Represents id of a matchup
        ///</summary>
        public int Id { get; set; }

    }

}