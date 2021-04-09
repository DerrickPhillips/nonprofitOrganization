using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nonprofitOrganization.Models
{
    public class Fund
    {
        // Code for the Fund fields DP.

        [Key]
        public int FundID { get; set; }

        //[ForeignKey("Amount")]
        public double Amount { get; set; }
        public Donation Donation { get; set; }

        //[ForeignKey("Dues")]
        public double Dues { get; set; }
        public Member Member { get; set; }
    }
}
