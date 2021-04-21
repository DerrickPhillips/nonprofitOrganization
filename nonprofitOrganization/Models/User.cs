using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using System.Data;

namespace nonprofitOrganization.Models
{
    public class User : IdentityUser
    {
        

        //public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        //Code that enables the user to be able to change Username 10 times max DP.
        public int UsernameChangeLimit { get; set; } = 10;

        //Code that enables the user to set a profile picture DP.
        public byte[] ProfilePicture { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberID { get; set; }

        [NotMapped]
        public IList<string> RoleNames { get; set; }

        
    }
}
