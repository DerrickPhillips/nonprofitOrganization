using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace nonprofitOrganization.Models
{
    public class News
    {
        public int NewsID { get; set; }

        [DataType(DataType.Date)]
        public DateTime DatePosted { get; set; }

        public string NewsAuthor { get; set; }

        //[Required(ErrorMessage = "Please enter a title for the News Story")]
        public string NewsTitle { get; set; }

        [Required(ErrorMessage = "Must enter text for the News Story")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }
}
