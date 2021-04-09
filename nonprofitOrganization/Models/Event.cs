using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nonprofitOrganization.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }

        //[ForeignKey("MemberID")]
        public int MemberID { get; set; }
        //public Member Member { get; set; }

        [Required]
        public string EventName { get; set; }

        [Required]
        public string EventDescription { get; set; }

        [Required]
        public DateTime? EventDate { get; set; }

        [Required]
        public string EventLocation { get; set; }

        [Required]
        public string EventLeader { get; set; }

        [Required]
        public string GuestList { get; set; }

        //public Member Member { get; set; }
    }
}
