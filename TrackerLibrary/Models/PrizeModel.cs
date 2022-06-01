using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        ///<summary>
        /// Represents finishin position of a team
        ///</summary>
        public int PlaceNumber { get; set; }
        ///<summary>
        /// Represents name of the place (First Place, Last Place)
        ///</summary>
        public string PlaceName { get; set; }
        ///<summary>
        /// Represents amount of winnings
        ///</summary>
        public decimal PrizeAmount { get; set; }
        ///<summary>
        /// Represents prize percentage if being used
        ///</summary>
        public double PrizePercentage { get; set; }
        ///<summary>
        /// Represents id of a prize
        ///</summary>
        public int Id { get; set; }

        public PrizeModel()
        {

        }
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;


        }

    }

}
