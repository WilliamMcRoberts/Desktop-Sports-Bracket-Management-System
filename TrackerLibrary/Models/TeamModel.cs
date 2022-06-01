using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        ///<summary>
        /// Represents name of a team
        ///</summary>
        public string TeamName { get; set; }
        ///<summary>
        /// Represents list of people on a team
        ///</summary>
        public List<PersonModel> TeamMembers { get; set; } = new();
        ///<summary>
        /// Represents id of a team
        ///</summary>
        public int Id { get; set; }
    }

}
