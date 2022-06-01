using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        ///<summary>
        /// Represents one team in a matchup
        ///</summary>
        public TeamModel TeamCompeting { get; set; }
        ///<summary>
        /// Represents score in a matchup
        ///</summary>
        public double Score { get; set; }
        ///<summary>
        /// Represents matchup team came from as winner
        ///</summary>
        public MatchupModel ParentMatchup { get; set; }
        ///<summary>
        /// Represents id of a matchup entry
        ///</summary>
        public int Id { get; set; }
        ///<summary>
        /// Constructor for Matchup Entry
        ///</summary>
        ///<param name="initialScore">
        ///
        ///</param>
 

    }

}
