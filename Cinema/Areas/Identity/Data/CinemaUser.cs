using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Cinema.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the CinemaUser class
    public class CinemaUser : IdentityUser
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string PassportData { get; set; }
        [ForeignKey("JobId")]
        public int JobId { get; set; }
        public virtual Job Job { get; set; }
    }
}
