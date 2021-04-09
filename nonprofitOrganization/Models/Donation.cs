using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nonprofitOrganization.Models
{
    public class Donation
    {
        // Code for the Donation fields DP.

        [Key]
        public int DonationID { get; set; }

        public DateTime DateDonated { get; set; }

        public string Comments { get; set; }

        [ForeignKey("DonorID")] // Passing in the name of the foreign key prooperty DP.
        public int DonorID { get; set; }
        public Donor Donor { get; set; }

        [Range(0, 10000, ErrorMessage = "Please enter an amount")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Numbers only")]
        public double Amount { get; set; }

        [Range(1000000000000000, 99999999999999999, ErrorMessage = "Please enter a valid Card number ")]
        [NotMapped]
        public long CardNumber { get; set; }

        [Required(ErrorMessage = "Please select a card network from the options below")]
        [NotMapped]
        public string CardNetwork { get; set; }

        [Range(0, 13, ErrorMessage = "Please enter a valid Expiration month ")]
        [NotMapped]
        public int ExpMonth { get; set; }

        [Range(2021, 2030, ErrorMessage = "Please select the expiration year as it appears on your card")]
        [NotMapped]
        public int ExpYear { get; set; }

        [Range(100, 999, ErrorMessage = "Please enter the CVV code located at the back of you card")]
        [NotMapped]
        public int CVV { get; set; }

        [NotMapped]
        public bool ValidCard { get; set; }

        public List<Fund> Funds { get; set; }
    }
}
