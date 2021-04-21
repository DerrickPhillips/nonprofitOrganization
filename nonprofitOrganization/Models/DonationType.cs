using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace nonprofitOrganization.Models
{
    public class DonationType
    {
        // Code for the DonationType Fields DP.
        [Key]
        public int TypeID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
