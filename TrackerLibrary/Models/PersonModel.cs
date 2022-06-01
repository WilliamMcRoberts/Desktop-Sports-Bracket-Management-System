using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        ///<summary>
        /// Represents first name of a person
        ///</summary>
        public string FirstName { get; set; }
        ///<summary>
        /// Represents last name of a person
        ///</summary>
        public string LastName { get; set; }
        ///<summary>
        /// Represents email address of a person
        ///</summary>
        public string EmailAddress { get; set; }
        ///<summary>
        /// Represents cell phone number of a person
        ///</summary>
        public string CellPhoneNumber { get; set; }
        ///<summary>
        /// Represents id of a person
        ///</summary>
        public int Id { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }

}