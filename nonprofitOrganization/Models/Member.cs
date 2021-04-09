using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nonprofitOrganization.Models
{
    public class Member
    {
        [ForeignKey("MemberID")]
        public string MemberID { get; set; }
        public User User { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public double Dues { get; set; }

        [Required]
        public string PaymentType { get; set; }

        public DateTime DueDate { get; set; }

        [Required]
        public string MailingListMember { get; set; }

        public string Comments { get; set; }

        [Required]
        public string ContactPref { get; set; }

        public List<Fund> Funds { get; set; }
    }
}
