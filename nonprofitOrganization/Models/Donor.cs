using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace nonprofitOrganization.Models
{
    public class Donor
    {
        // Code for the Donor fields DP.
        [ForeignKey("Id")]
        public int DonorID { get; set; }

        // Addres, Phone, Email and Contact Preference are not required fields to enable anonymous donations DP.
        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string ContactPreference { get; set; }
    }
}
