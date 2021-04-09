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
        public int DonorID { get; set; }

        // Addres, Phone, Email and Contact Preference are not required fields to enable anonymous donations DP.

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string ContactPreference { get; set; }

        //[ForeignKey("DonorFK")] // Passing in the name of the foreign key property in the dependent class(Donations) DP.
        public ICollection<Donation> Donations { get; set; }
    }
}
