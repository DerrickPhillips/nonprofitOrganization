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
        [Key]
        public Int64 UniqueId { get; set; }

        // Code for the foreign key field DP.
        [ForeignKey("DonationId")]
        public string Id { get; set; }

        // Code for the foreign key field DP.
        [ForeignKey("DonationType")]
        public int TypeID { get; set; }
        public DonationType DonationType { get; set; }

        [Required(ErrorMessage = "Please make sure you have fill out the amount field and have selected a type of donation")]
        public int DonationID { get; set; }

        [Range(0, 10000, ErrorMessage = "Please fill the Amount textbox")]
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

        public DateTime DateDonated { get; set; }

        public string Comments { get; set; }

        public int DonorID { get; set; }

        public Donor Donor { get; set; }
    }
}
