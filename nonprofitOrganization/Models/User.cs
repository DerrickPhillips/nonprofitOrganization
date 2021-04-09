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

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberID { get; set; }

        //public List<Member> Members { get; set; }

        [NotMapped]
        public IList<string> RoleNames { get; set; }

        
    }
}
